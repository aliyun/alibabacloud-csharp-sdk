// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantUserRequest : TeaModel {
        /// <summary>
        /// The description of the database.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The role of the user account.   
        /// 
        /// - In Oracle mode, this parameter is left unspecified.    
        /// - In MySQL mode, the super administrator account has ALL PRIVILEGES, and you can leave this parameter unspecified.   
        ///  
        /// You need to specify the account information for a general user account. By default, the account information is a JSON array that contains the information of the role and the schema (Oracle mode) or database (MySQL mode). Valid values:  
        /// 
        /// - ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.    
        /// - ReadOnly: a role that has only the read-only privilege SELECT.   
        /// - DDL: a role that has DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.   
        ///    
        /// - DML: a role that has DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public string Roles { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The name of the database account.   
        /// You cannot use reserved keywords, such as SYS and root.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The password of the database account. 
        /// 
        /// > <br>It must be 10 to 32 characters in length and contain three types of the following characters: uppercase letters, lowercase letters, digits, and special characters. The special characters are ! @ # $ % ^ & \ * ( ) _ + - =
        /// </summary>
        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// The type of the database account. Valid values:   
        /// 
        /// - Admin: the super administrator account.   
        /// - Normal: a general account.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
