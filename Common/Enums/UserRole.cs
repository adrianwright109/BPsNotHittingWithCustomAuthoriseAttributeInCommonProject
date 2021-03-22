using System;
using System.ComponentModel;

namespace Common.Enums
{
    [Serializable]
    public enum UserRole
    {
        [Description("Admin User")]
        AdminUser = 'A',

        [Description("Standard User")]
        StandardUser = 'U',

        [Description("Read-Only User")]
        ReadOnlyUser = 'R'
    }
}
