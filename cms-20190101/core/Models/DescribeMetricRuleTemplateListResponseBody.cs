// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListResponseBody : TeaModel {
        /// <summary>
        /// The timestamp when the alert template was applied to the application group.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The list of alert templates.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The keyword of the alert template name.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the alert template.
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
                /// The ID of the request.
                /// </summary>
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

                        /// <summary>
                        /// For more information about common request parameters, see [Common parameters](~~199331~~).
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                /// <summary>
                /// The order in which you want to sort alert templates. Default value: true. Valid values:
                /// 
                /// *   true: ascending order
                /// *   false: descending order
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The number of the page to return.
                /// 
                /// Default value: 1
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// The application history of the alert template.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the alert template.
                /// </summary>
                [NameInMap("RestVersion")]
                [Validation(Required=false)]
                public long? RestVersion { get; set; }

                /// <summary>
                /// The description of the alert template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// The sorting basis. Default value: gmtCreate. Valid values:
        /// 
        /// *   gmtMotified: Sorts alert templates by modification time.
        /// *   gmtCreate: Sorts alert templates by creation time.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
