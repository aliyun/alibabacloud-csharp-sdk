// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeDynamicTagRuleListResponseBody : TeaModel {
        /// <summary>
        /// The tag value.
        /// 
        /// The `TagValue` and `TagValueMatchFunction` parameters must be used in pairs.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The tag value.
        /// 
        /// For more information about how to obtain a tag value, see [DescribeTagKeyList](~~145557~~).
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status of adding instances that meet the tag rule to the application group. Valid values:
        /// 
        /// *   `RUNNING`
        /// *   `FINISH`
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The ID of the region to which the tags belong.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The logical operator that is used between conditional expressions. Valid values:
        /// 
        /// *   `and`
        /// *   `or`
        /// 
        /// >  Only one logical operator can be used in a request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag key.
        /// 
        /// For more information about how to obtain a tag key, see [DescribeTagKeyList](~~145558~~).
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the tag rule.
        /// </summary>
        [NameInMap("TagGroupList")]
        [Validation(Required=false)]
        public DescribeDynamicTagRuleListResponseBodyTagGroupList TagGroupList { get; set; }
        public class DescribeDynamicTagRuleListResponseBodyTagGroupList : TeaModel {
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup> TagGroup { get; set; }
            public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup : TeaModel {
                [NameInMap("ContactGroupList")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupContactGroupList ContactGroupList { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupContactGroupList : TeaModel {
                    [NameInMap("ContactGroupList")]
                    [Validation(Required=false)]
                    public List<string> ContactGroupList { get; set; }

                }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("MatchExpress")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress MatchExpress { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// For more information about common request parameters, see [Common parameters](~~199331~~).
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        /// <summary>
                        /// Queries tag rules.
                        /// </summary>
                        [NameInMap("TagValueMatchFunction")]
                        [Validation(Required=false)]
                        public string TagValueMatchFunction { get; set; }

                    }

                }

                /// <summary>
                /// The number of the page to return.
                /// 
                /// Pages start from page 1. Default value: 1.
                /// </summary>
                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The alert contact group.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TemplateIdList")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTemplateIdList TemplateIdList { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTemplateIdList : TeaModel {
                    [NameInMap("TemplateIdList")]
                    [Validation(Required=false)]
                    public List<string> TemplateIdList { get; set; }

                }

            }

        }

        /// <summary>
        /// The tag rules of application groups.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
