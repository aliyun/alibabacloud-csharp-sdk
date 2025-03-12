// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantUserRequest : TeaModel {
        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>加密方式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAS</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Encrypt,Decrypt</para>
        /// </summary>
        [NameInMap("GlobalPermissions")]
        [Validation(Required=false)]
        public string GlobalPermissions { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The role of the user account.  In Oracle mode, this parameter unspecified is left unspecified.  In MySQL mode, the super administrator account has ALL PRIVILEGES, and you can leave this parameter unspecified.  You need to specify the account information for a general user account. By default, the account information is a JSON array that contains the information of the role and the schema (Oracle mode) or database (MySQL mode).  Valid values: ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES. ReadOnly: a role that has only the read-only privilege SELECT. DDL: a role that has DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW. DML: a role that has DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Database&quot;:&quot;oceanbase1&quot;,&quot;Role&quot;:&quot;readwrite&quot;},{&quot;Database&quot;:&quot;oceanbase2&quot;,&quot;Role&quot;:&quot;readonly&quot;}]</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public string Roles { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The name of the database account.  You cannot use reserved keywords, such as SYS and root.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay_test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The password of the database account.  It must be 10 to 32 characters in length and contain three types of the following characters: uppercase letters, lowercase letters, digits, and special characters. The special characters are ! @ # $ % \ ^ \ &amp; \ * ( ) _ + - =</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>!Aliyun4Oceanbase</para>
        /// </summary>
        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// <para>The type of the database account. Valid values: Admin: the super administrator account. Normal: a general account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
