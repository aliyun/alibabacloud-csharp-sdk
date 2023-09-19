// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The queried alert templates.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateListResponseBodyTemplates Templates { get; set; }
        public class DescribeMetricRuleTemplateListResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate> Template { get; set; }
            public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate : TeaModel {
                /// <summary>
                /// The history of applying the alert templates to application groups.
                /// </summary>
                [NameInMap("ApplyHistories")]
                [Validation(Required=false)]
                public DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories ApplyHistories { get; set; }
                public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories : TeaModel {
                    [NameInMap("ApplyHistory")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory> ApplyHistory { get; set; }
                    public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory : TeaModel {
                        /// <summary>
                        /// The timestamp when the alert template was applied to the application group.
                        /// 
                        /// Unit: milliseconds.
                        /// </summary>
                        [NameInMap("ApplyTime")]
                        [Validation(Required=false)]
                        public long? ApplyTime { get; set; }

                        /// <summary>
                        /// The ID of the application group.
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        /// <summary>
                        /// The name of the application group.
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                /// <summary>
                /// The description of the alert template.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The timestamp when the alert template was created.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The timestamp when the alert template was modified.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// The name of the alert template.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The version of the alert template.
                /// 
                /// Default value: 0.
                /// </summary>
                [NameInMap("RestVersion")]
                [Validation(Required=false)]
                public long? RestVersion { get; set; }

                /// <summary>
                /// The ID of the alert template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
