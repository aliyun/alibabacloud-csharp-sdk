// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account.</para>
        /// <list type="bullet">
        /// <item><description><para>Cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>Be up to 256 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Database test account</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the database account. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Start with a lowercase letter and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>Contain only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Be 2 to 16 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Cannot be a reserved name, such as root, admin, or opsadmin.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_accout</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>The special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// </description></item>
        /// <item><description><para>Be 8 to 32 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test_accout1</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: A standard account. A cluster can have a maximum of 256 standard accounts.</para>
        /// </description></item>
        /// <item><description><para><b>Super</b> (default): A privileged account. Only one privileged account can be created for a cluster.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If a cluster has no accounts, you can create a privileged account or a standard account. If a privileged account already exists in the cluster, you must set this parameter to Normal to create a standard account.</para>
        /// </description></item>
        /// <item><description><para>After an account is created, the privileged account has permissions on all databases in the cluster. A standard account has no permissions by default. A privileged account must be used to grant permissions on specific databases to the standard account. For more information, see <a href="https://help.aliyun.com/document_detail/123662.html">Grant permissions to a user</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The ID of the Data Warehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the cluster ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAccountRequestTag> Tag { get; set; }
        public class CreateAccountRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag \<c>N\\</c>. You can specify up to 20 tags. \<c>N\\</c> is the serial number of the tag and must be a unique integer that starts from 1.</para>
            /// <remarks>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag \<c>N\\</c>. \<c>N\\</c> corresponds to the \<c>N\\</c> in \<c>Tag.N.Key\\</c>.</para>
            /// <remarks>
            /// <para>The tag value can be up to 64 characters in length. It cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
