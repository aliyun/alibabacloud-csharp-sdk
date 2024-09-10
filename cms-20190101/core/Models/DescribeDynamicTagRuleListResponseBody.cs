// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeDynamicTagRuleListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The tag rules of application groups.
        /// </summary>
        [NameInMap("TagGroupList")]
        [Validation(Required=false)]
        public DescribeDynamicTagRuleListResponseBodyTagGroupList TagGroupList { get; set; }
        public class DescribeDynamicTagRuleListResponseBodyTagGroupList : TeaModel {
            [NameInMap("TagGroup")]
            [Validation(Required=false)]
            public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup> TagGroup { get; set; }
            public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroup : TeaModel {
                /// <summary>
                /// The alert contact group.
                /// </summary>
                [NameInMap("ContactGroupList")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupContactGroupList ContactGroupList { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupContactGroupList : TeaModel {
                    [NameInMap("ContactGroupList")]
                    [Validation(Required=false)]
                    public List<string> ContactGroupList { get; set; }

                }

                /// <summary>
                /// The ID of the tag rule.
                /// </summary>
                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                /// <summary>
                /// The conditional expressions used to create an application group based on the tag.
                /// </summary>
                [NameInMap("MatchExpress")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress MatchExpress { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupMatchExpressMatchExpress : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// 
                        /// The `TagValue` and `TagValueMatchFunction` parameters must be used in pairs.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        /// <summary>
                        /// The method that is used to match tag values. Valid values:
                        /// 
                        /// *   all: includes all
                        /// *   startWith: starts with a prefix
                        /// *   endWith: ends with a suffix
                        /// *   contains: contains
                        /// *   notContains: does not contain
                        /// *   equals: equals
                        /// </summary>
                        [NameInMap("TagValueMatchFunction")]
                        [Validation(Required=false)]
                        public string TagValueMatchFunction { get; set; }

                    }

                }

                /// <summary>
                /// The logical operator that is used between conditional expressions. Valid values:
                /// 
                /// *   `and`
                /// *   `or`
                /// 
                /// >  Only one logical operator can be used in a request.
                /// </summary>
                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                /// <summary>
                /// The ID of the region to which the tags belong.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of adding instances that meet the tag rule to the application group. Valid values:
                /// 
                /// *   `RUNNING`
                /// *   `FINISH`
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValueBlacklist")]
                [Validation(Required=false)]
                public DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTagValueBlacklist TagValueBlacklist { get; set; }
                public class DescribeDynamicTagRuleListResponseBodyTagGroupListTagGroupTagValueBlacklist : TeaModel {
                    [NameInMap("TagValueBlacklist")]
                    [Validation(Required=false)]
                    public List<string> TagValueBlacklist { get; set; }

                }

                /// <summary>
                /// The IDs of the alert templates.
                /// </summary>
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
