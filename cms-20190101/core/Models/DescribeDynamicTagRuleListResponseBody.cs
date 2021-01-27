// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeDynamicTagRuleListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TagGroupList")]
        [Validation(Required=false)]
        public DescribeDynamicTagRuleListResponseBodyTagGroupList TagGroupList { get; set; }
        public class DescribeDynamicTagRuleListResponseBodyTagGroupList : TeaModel {
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup> TagGroup { get; set; }
            public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup : TeaModel {
                public string Status { get; set; }
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress MatchExpress { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress : TeaModel {
                        [NameInMap("TagValueMatchFunction")]
                        [Validation(Required=false)]
                        public string TagValueMatchFunction { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTemplateIdList TemplateIdList { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTemplateIdList : TeaModel {
                    [NameInMap("TemplateIdList")]
                    [Validation(Required=false)]
                    public List<string> TemplateIdList { get; set; }

                }
                public string DynamicTagRuleId { get; set; }
                public string MatchExpressFilterRelation { get; set; }
                public string RegionId { get; set; }
                public string TagKey { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
