// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client that is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The snapshot replication information.</para>
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public string CrossRegionCopyInfoShrink { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The Policy Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the regions that support asynchronous replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The retention rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public string RetainRuleShrink { get; set; }

        /// <summary>
        /// <para>The schedule rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string ScheduleShrink { get; set; }

        /// <summary>
        /// <para>The special retention rules.</para>
        /// </summary>
        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public string SpecialRetainRulesShrink { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLED</description></item>
        /// <item><description>ENABLED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The advanced snapshot feature.</para>
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public string StorageRuleShrink { get; set; }

        /// <summary>
        /// <para>The tag key-value pairs. Valid values of n: 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEnterpriseSnapshotPolicyShrinkRequestTag> Tag { get; set; }
        public class CreateEnterpriseSnapshotPolicyShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISK</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISK</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
