// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The type of the database account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NormalAccount</b>: standard account</para>
        /// </description></item>
        /// <item><description><para><b>SuperAccount</b>: privileged account</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NormalAccount</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For testing</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about permissions.</para>
        /// </summary>
        [NameInMap("DmlAuthSetting")]
        [Validation(Required=false)]
        public CreateAccountRequestDmlAuthSetting DmlAuthSetting { get; set; }
        public class CreateAccountRequestDmlAuthSetting : TeaModel {
            /// <summary>
            /// <para>The databases on which you want to grant permissions. Separate multiple databases with commas (,).</para>
            /// </summary>
            [NameInMap("AllowDatabases")]
            [Validation(Required=false)]
            public List<string> AllowDatabases { get; set; }

            /// <summary>
            /// <para>The dictionaries on which you want to grant permissions. Separate multiple dictionaries with commas (,).</para>
            /// </summary>
            [NameInMap("AllowDictionaries")]
            [Validation(Required=false)]
            public List<string> AllowDictionaries { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant the DDL permissions to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The account has the permissions to execute DDL statements.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The account does not have the permissions to execute DDL statements.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DdlAuthority")]
            [Validation(Required=false)]
            public bool? DdlAuthority { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant the DML permissions to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The account has the permissions to read data from the database, write data to the database, and modify the settings of the database.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The account only has the permissions to read data from the database.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The account only has the permissions to read data from the database and modify the settings of the database.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DmlAuthority")]
            [Validation(Required=false)]
            public int? DmlAuthority { get; set; }

        }

        /// <summary>
        /// <para>The password of the database account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>The following special characters are supported: ! @ # $ % ^ &amp; \* ( ) _ + - =</para>
        /// </description></item>
        /// <item><description><para>The password must be 8 to 32 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4@</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The code of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
