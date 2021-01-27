// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateListResponseBodyTemplates Templates { get; set; }
        public class DescribeMetricRuleTemplateListResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate> Template { get; set; }
            public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplate : TeaModel {
                [NameInMap("ApplyHistory")]
                [Validation(Required=false)]
                public List<DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistory> ApplyHistory { get; set; }
                public class DescribeMetricRuleTemplateListResponseBodyTemplatesTemplateApplyHistory : TeaModel {
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
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
