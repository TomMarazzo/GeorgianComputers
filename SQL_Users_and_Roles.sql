INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('1', 'Administrator', 'Administrator');

INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('2', 'Customer', 'Customer');

INSERT INTO AspNetUserRoles (RoleId, UserId) (SELECT '1', Id FROM AspNetUsers);