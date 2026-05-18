// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>659401C0-6214-5C02-972A-CFA929D717B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateListResponseBodyTemplates Templates { get; set; }
        public class DescribeMetricRuleTemplateListResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate> Template { get; set; }
            public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate : TeaModel {
                [NameInMap("ApplyHistories")]
                [Validation(Required=false)]
                public DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories ApplyHistories { get; set; }
                public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories : TeaModel {
                    [NameInMap("ApplyHistory")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory> ApplyHistory { get; set; }
                    public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory : TeaModel {
                        [NameInMap("ApplyTime")]
                        [Validation(Required=false)]
                        public long? ApplyTime { get; set; }

                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RestVersion")]
                [Validation(Required=false)]
                public long? RestVersion { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
