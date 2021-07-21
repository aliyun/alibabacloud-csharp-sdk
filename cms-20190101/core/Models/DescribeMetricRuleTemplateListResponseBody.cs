// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

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
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public string Name { get; set; }
                public long? RestVersion { get; set; }
                public long? GmtModified { get; set; }
                public long? TemplateId { get; set; }
                public DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories ApplyHistories { get; set; }
                public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistories : TeaModel {
                    [NameInMap("ApplyHistory")]
                    [Validation(Required=false)]
                    public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory> ApplyHistory { get; set; }
                    public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistoriesApplyHistory : TeaModel {
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        [NameInMap("ApplyTime")]
                        [Validation(Required=false)]
                        public long? ApplyTime { get; set; }

                    }

                }
            }
        };

    }

}
