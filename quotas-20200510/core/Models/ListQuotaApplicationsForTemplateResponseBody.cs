// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of records returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the start of the data to read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of historical quota applications.</para>
        /// </summary>
        [NameInMap("QuotaBatchApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications> QuotaBatchApplications { get; set; }
        public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications : Darabonba.Model {
            /// <summary>
            /// <para>The list of Alibaba Cloud accounts of the members in a resource directory for which the quota applications are submitted.</para>
            /// </summary>
            [NameInMap("AliyunUids")]
            [Validation(Required=false)]
            public List<string> AliyunUids { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota increase application was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-23T02:38:18Z</para>
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// <para>The number of applications in different approval states.</para>
            /// </summary>
            [NameInMap("AuditStatusVos")]
            [Validation(Required=false)]
            public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos> AuditStatusVos { get; set; }
            public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos : Darabonba.Model {
                /// <summary>
                /// <para>The number of applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The approval status of the quota increase application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Disagree: denied.</para>
                /// </description></item>
                /// <item><description><para>Agree: approved.</para>
                /// </description></item>
                /// <item><description><para>Process: pending approval.</para>
                /// </description></item>
                /// <item><description><para>Cancel: closed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Agree</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the batch quota application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
            /// </summary>
            [NameInMap("BatchQuotaApplicationId")]
            [Validation(Required=false)]
            public string BatchQuotaApplicationId { get; set; }

            /// <summary>
            /// <para>The requested quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public double? DesireValue { get; set; }

            /// <summary>
            /// <para>The quota dimensions.</para>
            /// <para>Format: {&quot;regionId&quot;:&quot;cn-hangzhou&quot;}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-22T16:00:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-14T02:08:56Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_fhoz4k</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CommonQuota: general quota.</para>
            /// </description></item>
            /// <item><description><para>FlowControl: API rate limit.</para>
            /// </description></item>
            /// <item><description><para>WhiteListLabel: privilege.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The reason for the quota increase application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business expansion</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D47B3A10-CDAC-5412-B2EE-EC9A3DBE9053</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

