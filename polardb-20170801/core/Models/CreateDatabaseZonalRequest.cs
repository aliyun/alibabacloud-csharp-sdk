// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDatabaseZonalRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account that is authorized to access the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permissions of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ReadWrite: read and write permissions.</description></item>
        /// <item><description>ReadOnly: read-only permissions.</description></item>
        /// <item><description>DMLOnly: DML-only permissions.</description></item>
        /// <item><description>DDLOnly: DDL-only permissions.</description></item>
        /// <item><description>ReadIndex: read and index permissions.</description></item>
        /// </list>
        /// <para>Default value: ReadWrite.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The character set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. It can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The locale setting used to specify the collation of the new database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>The locale setting used to specify the character classification of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB on ENS edge cluster. Regular PolarDB cluster IDs are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the database. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// <para>The name of the database. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>It must start with a letter and end with a letter or digit. It can be up to 64 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
