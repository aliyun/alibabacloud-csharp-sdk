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

                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

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

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagValueMatchFunction")]
                        [Validation(Required=false)]
                        public string TagValueMatchFunction { get; set; }

                    }

                }

                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
