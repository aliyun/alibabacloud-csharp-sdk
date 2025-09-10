// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationTemplatesResponseBody : TeaModel {
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
        /// <para>The token that marks the position at which the query ends.</para>
        /// <remarks>
        /// <para>An empty value indicates that all data is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about quota templates.</para>
        /// </summary>
        [NameInMap("QuotaApplicationTemplates")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplates> QuotaApplicationTemplates { get; set; }
        public class ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplates : TeaModel {
            /// <summary>
            /// <para>None.</para>
            /// </summary>
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<float?> ApplicableRange { get; set; }

            /// <summary>
            /// <para>The type of the adjustable value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>continuous</description></item>
            /// <item><description>discontinuous</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>continuous</para>
            /// </summary>
            [NameInMap("ApplicableType")]
            [Validation(Required=false)]
            public string ApplicableType { get; set; }

            /// <summary>
            /// <para>The requested value of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>802</para>
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public float? DesireValue { get; set; }

            /// <summary>
            /// <para>The quota dimensions.</para>
            /// <para>Format: {&quot;regionId&quot;:&quot;Region&quot;}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the quota. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-28T06:07:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The language of the quota alert notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh: Chinese</description></item>
            /// <item><description>en: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("EnvLanguage")]
            [Validation(Required=false)]
            public string EnvLanguage { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the quota. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-29T06:07:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the quota template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether Quota Center sends a notification about the application result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>3: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public int? NoticeType { get; set; }

            /// <summary>
            /// <para>The calculation cycle of the quota.</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplatesPeriod Period { get; set; }
            public class ListQuotaApplicationTemplatesResponseBodyQuotaApplicationTemplatesPeriod : TeaModel {
                /// <summary>
                /// <para>The unit of the calculation cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>second</description></item>
                /// <item><description>minute</description></item>
                /// <item><description>hour</description></item>
                /// <item><description>day</description></item>
                /// <item><description>week</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the calculation cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonQuota: general quota</description></item>
            /// <item><description>FlowControl: API rate limit</description></item>
            /// <item><description>WhiteListLabel: privilege</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The description of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of security groups that can be created by the current account.</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The name of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Security Groups</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

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
        /// <para>The total number of records returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
