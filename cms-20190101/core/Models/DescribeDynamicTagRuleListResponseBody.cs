// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeDynamicTagRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D50523D-8D59-4A61-B58E-E2286ECFB3A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The tag rules of application groups.</para>
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
                /// <para>The alert contact group.</para>
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
                /// <para>The ID of the tag rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1536df65-a719-429d-8813-73cc40d7****</para>
                /// </summary>
                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                /// <summary>
                /// <para>The conditional expressions used to create an application group based on the tag.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>azone-version</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// <para>The <c>TagValue</c> and <c>TagValueMatchFunction</c> parameters must be used in pairs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description></description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        /// <summary>
                        /// <para>The method that is used to match tag values. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>all: includes all</description></item>
                        /// <item><description>startWith: starts with a prefix</description></item>
                        /// <item><description>endWith: ends with a suffix</description></item>
                        /// <item><description>contains: contains</description></item>
                        /// <item><description>notContains: does not contain</description></item>
                        /// <item><description>equals: equals</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>all</para>
                        /// </summary>
                        [NameInMap("TagValueMatchFunction")]
                        [Validation(Required=false)]
                        public string TagValueMatchFunction { get; set; }

                    }

                }

                /// <summary>
                /// <para>The logical operator that is used between conditional expressions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>and</c></description></item>
                /// <item><description><c>or</c></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only one logical operator can be used in a request.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>or</para>
                /// </summary>
                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the tags belong.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of adding instances that meet the tag rule to the application group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>RUNNING</c></description></item>
                /// <item><description><c>FINISH</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FINISH</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagkey1</para>
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
                /// <para>The IDs of the alert templates.</para>
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
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
