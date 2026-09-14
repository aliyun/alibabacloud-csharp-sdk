// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique across different requests. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cross-region copy destination information.</para>
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public string CrossRegionCopyInfoShrink { get; set; }

        /// <summary>
        /// <para>The description of the snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The ID of the policy to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The snapshot policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esp-xxx</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The retention rule.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public string RetainRuleShrink { get; set; }

        /// <summary>
        /// <para>The schedule rule.</para>
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
        /// <para>The status of the snapshot policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED</description></item>
        /// <item><description>DISABLED</description></item>
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

    }

}
