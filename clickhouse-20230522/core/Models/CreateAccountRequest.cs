// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The database account. The account name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The name must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 2 to 64 characters in length.</description></item>
        /// </list>
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
        /// <item><description><b>NormalAccount</b>: Standard account.</description></item>
        /// <item><description><b>SuperAccount</b>: Privileged account.</description></item>
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
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For testing purposes</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The authorization information.</para>
        /// </summary>
        [NameInMap("DmlAuthSetting")]
        [Validation(Required=false)]
        public CreateAccountRequestDmlAuthSetting DmlAuthSetting { get; set; }
        public class CreateAccountRequestDmlAuthSetting : TeaModel {
            /// <summary>
            /// <para>The list of databases to be authorized. Separate multiple databases with commas (,).</para>
            /// </summary>
            [NameInMap("AllowDatabases")]
            [Validation(Required=false)]
            public List<string> AllowDatabases { get; set; }

            /// <summary>
            /// <para>The list of dictionaries to be authorized. Separate multiple dictionaries with commas (,).</para>
            /// </summary>
            [NameInMap("AllowDictionaries")]
            [Validation(Required=false)]
            public List<string> AllowDictionaries { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant DDL permissions to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Allows DDL operations.</description></item>
            /// <item><description><b>false</b>: Prohibits DDL operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DdlAuthority")]
            [Validation(Required=false)]
            public bool? DdlAuthority { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant DML permissions to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Allows queries for reading, writing, and changing settings.</description></item>
            /// <item><description><b>1</b>: Allows only queries for reading data.</description></item>
            /// <item><description><b>2</b>: Allows queries for reading data and changing settings.</description></item>
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
        /// <item><description><para>Special characters include !@#$%^&amp;*()_+-=.</para>
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
        /// <para>The product code.</para>
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
