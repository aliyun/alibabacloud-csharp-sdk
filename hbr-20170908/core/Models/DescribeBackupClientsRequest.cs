// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsRequest : TeaModel {
        /// <summary>
        /// <para>The list of backup client IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-*********************&quot;]</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public List<string> ClientIds { get; set; }

        /// <summary>
        /// <para>The type of the backup client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_CLIENT</b>: ECS File Backup client.</description></item>
        /// <item><description><b>CONTAINER_CLIENT</b>: container backup client.</description></item>
        /// <item><description><b>LOCAL_CLIENT</b>: local NAS backup, CPFS backup, archive, or data synchronization client.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_CLIENT</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The ID of the backup cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000ge4wa61b4d337xblq</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role created in the source account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The type of cross-account backup. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: backup within the current account. </description></item>
        /// <item><description>CROSS_ACCOUNT: cross-account backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source account used for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>129374672382xxxx</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The query filters.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsRequestFilters> Filters { get; set; }
        public class DescribeBackupClientsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the query filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values to match in the query filter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The list of ECS instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-*********************&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Minimum value: 1. Maximum value: 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tag information to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33738719#</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsRequestTag> Tag { get; set; }
        public class DescribeBackupClientsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the backup vault. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. </description></item>
            /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the backup vault. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>. </description></item>
            /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The tag value cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
