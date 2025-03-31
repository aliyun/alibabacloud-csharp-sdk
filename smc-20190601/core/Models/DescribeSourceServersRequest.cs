// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeSourceServersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the migration job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-bp19vlwm0tyigbmj****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the migration source. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSourceServerName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of migration job that is associated with the migration source.</para>
        /// </summary>
        [NameInMap("RelatedJobType")]
        [Validation(Required=false)]
        public List<string> RelatedJobType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw3ty5y7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The migration source ID. You can specify multiple IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1e2fsl57knvuug****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// <para>The state of the migration source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Unavailable: The migration source is inactive, or an error occurs in the migration source.</description></item>
        /// <item><description>Available: The migration source is active.</description></item>
        /// <item><description>InUse: The migration source is being migrated.</description></item>
        /// <item><description>Deleting: The migration source is being deleted from Server Migration Center (SMC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSourceServersRequestTag> Tag { get; set; }
        public class DescribeSourceServersRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N that is attached to the SMC resource. Valid values of N: 1 to 20.</para>
            /// <para>You cannot specify an empty string as a tag key. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that is attached to the SMC resource. Valid values of N: 1 to 20.</para>
            /// <para>You can specify an empty string as a tag key. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The workgroup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-bp1ja22kdqphehlj****</para>
        /// </summary>
        [NameInMap("WorkgroupId")]
        [Validation(Required=false)]
        public string WorkgroupId { get; set; }

    }

}
