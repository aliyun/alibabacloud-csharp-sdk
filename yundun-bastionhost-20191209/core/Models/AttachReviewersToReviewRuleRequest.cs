// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachReviewersToReviewRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can call the DescribeInstances operation to obtain the bastion host instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-7mz2ve7h00a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The information about the auditors associated with the audit policy.</para>
        /// </summary>
        [NameInMap("Principals")]
        [Validation(Required=false)]
        public List<AttachReviewersToReviewRuleRequestPrincipals> Principals { get; set; }
        public class AttachReviewersToReviewRuleRequestPrincipals : TeaModel {
            /// <summary>
            /// <para>When PrincipalType is set to RamUser, specify the RAM user ID of the auditor to associate. When PrincipalType is set to RamRole, specify the RAM role ARN of the auditor to associate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160****9214</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The display name of the associated auditor\&quot;s RAM user or RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the auditor to associate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RamUser</b>: Resource Access Management (RAM) user.</para>
            /// </description></item>
            /// <item><description><para><b>RamRole</b>: RAM role.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamUser</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the audit policy.</para>
        /// <remarks>
        /// <para>You can call the ListReviewRules operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReviewRuleId")]
        [Validation(Required=false)]
        public long? ReviewRuleId { get; set; }

    }

}
