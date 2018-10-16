namespace FinalDNDSheetProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharacterArmors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        armorDesc = c.String(),
                        ac = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Equipment_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_id)
                .Index(t => t.Equipment_id);
            
            CreateTable(
                "dbo.CharacterInventories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        platinum = c.Int(nullable: false),
                        gold = c.Int(nullable: false),
                        electrum = c.Int(nullable: false),
                        silver = c.Int(nullable: false),
                        copper = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        itemDesc = c.String(),
                        weight = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        CharacterInventory_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CharacterInventories", t => t.CharacterInventory_id)
                .Index(t => t.CharacterInventory_id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        charName = c.String(),
                        charRace = c.String(),
                        charLevel = c.Int(nullable: false),
                        charExpPoints = c.Int(nullable: false),
                        charClass = c.String(),
                        charBackground = c.String(),
                        charSubrace = c.String(),
                        charAge = c.Int(nullable: false),
                        charHeight = c.String(),
                        charWeight = c.Int(nullable: false),
                        charEquipWeight = c.Int(nullable: false),
                        charLifestyle = c.String(),
                        charDiety = c.String(),
                        charAlightment = c.String(),
                        charPersonalityTraits = c.String(),
                        charIdeals = c.String(),
                        charBonds = c.String(),
                        charFlaws = c.String(),
                        charProficencies = c.String(),
                        charFeatures = c.String(),
                        charTraits = c.String(),
                        charEquipment_id = c.Int(),
                        charInventory_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Equipments", t => t.charEquipment_id)
                .ForeignKey("dbo.CharacterInventories", t => t.charInventory_id)
                .Index(t => t.charEquipment_id)
                .Index(t => t.charInventory_id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CharacterWeapons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        weaponName = c.String(),
                        weaponDesc = c.String(),
                        atkType = c.String(),
                        damage = c.String(),
                        properties = c.String(),
                        weight = c.Int(nullable: false),
                        Equipment_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Equipments", t => t.Equipment_id)
                .Index(t => t.Equipment_id);
            
            CreateTable(
                "dbo.CharacterSkills",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        statMod = c.String(),
                        Characters_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Characters", t => t.Characters_id)
                .Index(t => t.Characters_id);
            
            CreateTable(
                "dbo.Spells",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        spellName = c.String(),
                        level = c.Int(nullable: false),
                        spellDesc = c.String(),
                        spellRange = c.Int(nullable: false),
                        castDuration = c.String(),
                        castTime = c.String(),
                        spellComponents = c.String(),
                        Characters_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Characters", t => t.Characters_id)
                .Index(t => t.Characters_id);
            
            CreateTable(
                "dbo.CharacterStats",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ac = c.Int(nullable: false),
                        hitPointsMax = c.Int(nullable: false),
                        inititive = c.Int(nullable: false),
                        speed = c.Int(nullable: false),
                        hitPointsCurrent = c.Int(nullable: false),
                        hitPointsTemp = c.Int(nullable: false),
                        strength = c.Int(nullable: false),
                        strengthMod = c.Int(nullable: false),
                        dex = c.Int(nullable: false),
                        dexMod = c.Int(nullable: false),
                        constitution = c.Int(nullable: false),
                        constitutionMod = c.Int(nullable: false),
                        intelligence = c.Int(nullable: false),
                        intelligenceMod = c.Int(nullable: false),
                        wisdom = c.Int(nullable: false),
                        wisdomMod = c.Int(nullable: false),
                        charisma = c.Int(nullable: false),
                        charismaMod = c.Int(nullable: false),
                        profBonus = c.Int(nullable: false),
                        perception = c.Int(nullable: false),
                        hitDiceHeal = c.Int(nullable: false),
                        hitDiceAmount = c.Int(nullable: false),
                        spellAbility = c.String(),
                        spellSave = c.Int(nullable: false),
                        spellAtkBonus = c.Int(nullable: false),
                        spellClass = c.String(),
                        Characters_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Characters", t => t.Characters_id)
                .Index(t => t.Characters_id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.CharacterStats", "Characters_id", "dbo.Characters");
            DropForeignKey("dbo.Spells", "Characters_id", "dbo.Characters");
            DropForeignKey("dbo.CharacterSkills", "Characters_id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "charInventory_id", "dbo.CharacterInventories");
            DropForeignKey("dbo.Characters", "charEquipment_id", "dbo.Equipments");
            DropForeignKey("dbo.CharacterWeapons", "Equipment_id", "dbo.Equipments");
            DropForeignKey("dbo.CharacterArmors", "Equipment_id", "dbo.Equipments");
            DropForeignKey("dbo.Items", "CharacterInventory_id", "dbo.CharacterInventories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.CharacterStats", new[] { "Characters_id" });
            DropIndex("dbo.Spells", new[] { "Characters_id" });
            DropIndex("dbo.CharacterSkills", new[] { "Characters_id" });
            DropIndex("dbo.CharacterWeapons", new[] { "Equipment_id" });
            DropIndex("dbo.Characters", new[] { "charInventory_id" });
            DropIndex("dbo.Characters", new[] { "charEquipment_id" });
            DropIndex("dbo.Items", new[] { "CharacterInventory_id" });
            DropIndex("dbo.CharacterArmors", new[] { "Equipment_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.CharacterStats");
            DropTable("dbo.Spells");
            DropTable("dbo.CharacterSkills");
            DropTable("dbo.CharacterWeapons");
            DropTable("dbo.Equipments");
            DropTable("dbo.Characters");
            DropTable("dbo.Items");
            DropTable("dbo.CharacterInventories");
            DropTable("dbo.CharacterArmors");
        }
    }
}
