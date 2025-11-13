// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the check items.</para>
        /// </summary>
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<ListCheckItemsResponseBodyCheckItems> CheckItems { get; set; }
        public class ListCheckItemsResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// <para>The help information for the check item.</para>
            /// </summary>
            [NameInMap("AssistInfo")]
            [Validation(Required=false)]
            public ListCheckItemsResponseBodyCheckItemsAssistInfo AssistInfo { get; set; }
            public class ListCheckItemsResponseBodyCheckItemsAssistInfo : TeaModel {
                /// <summary>
                /// <para>The type of the help information for the check item risk. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>：Text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The content of the help information for the check item risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test assistInfo.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000001</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>A list of standard, regulation, and section information associated with the check result.</para>
            /// </summary>
            [NameInMap("CheckPolicies")]
            [Validation(Required=false)]
            public List<ListCheckItemsResponseBodyCheckItemsCheckPolicies> CheckPolicies { get; set; }
            public class ListCheckItemsResponseBodyCheckItemsCheckPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the requirement for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000001</para>
                /// </summary>
                [NameInMap("RequirementId")]
                [Validation(Required=false)]
                public long? RequirementId { get; set; }

                /// <summary>
                /// <para>The display name of the requirement for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testRequirementShowName</para>
                /// </summary>
                [NameInMap("RequirementShowName")]
                [Validation(Required=false)]
                public string RequirementShowName { get; set; }

                /// <summary>
                /// <para>The ID of the section for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000001</para>
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public long? SectionId { get; set; }

                /// <summary>
                /// <para>The display name of the section for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testSectionShowName</para>
                /// </summary>
                [NameInMap("SectionShowName")]
                [Validation(Required=false)]
                public string SectionShowName { get; set; }

                /// <summary>
                /// <para>检查项的标准ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000001</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <para>The display name of the standard for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testStandardShowName</para>
                /// </summary>
                [NameInMap("StandardShowName")]
                [Validation(Required=false)]
                public string StandardShowName { get; set; }

                /// <summary>
                /// <para>The name of the associated policy category:</para>
                /// <list type="bullet">
                /// <item><description><b>AISPM</b>：AI Configuration Management (AI-SPM)</description></item>
                /// <item><description><b>KISPM</b>：Kubernetes Configuration Management (KSPM)</description></item>
                /// <item><description><b>IDENTITY_PERMISSION</b>：Identity and Permission Management (CIEM)</description></item>
                /// <item><description><b>RISK</b>：Security Risk</description></item>
                /// <item><description><b>COMPLIANCE</b>：Compliance Risk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AISPM</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>自定义检查项定义规则。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AssociatedData&quot;:{&quot;ToDataList&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;FromPropertyPath&quot;:&quot;InstanceId&quot;}]},&quot;MatchProperty&quot;:{&quot;Operator&quot;:&quot;AND&quot;,&quot;MatchProperties&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Disk&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testId&quot;},{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testInstanceId&quot;}]}}</para>
            /// </summary>
            [NameInMap("CheckRule")]
            [Validation(Required=false)]
            public string CheckRule { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCheckItemName</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The source type of the Security Posture check item:</para>
            /// <list type="bullet">
            /// <item><description><b>CUSTOM</b>: User-defined</description></item>
            /// <item><description><b>SYSTEM</b>: Predefined by the Security Posture platform</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The description information of the check item.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public ListCheckItemsResponseBodyCheckItemsDescription Description { get; set; }
            public class ListCheckItemsResponseBodyCheckItemsDescription : TeaModel {
                /// <summary>
                /// <para>The type of the check description attribute. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>：Text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The specific content of the description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom description.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The sub-type of the cloud product\&quot;s asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISK</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Remark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark.</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>HIGH</b>: High risk</description></item>
            /// <item><description><b>MEDIUM</b>: Medium risk</description></item>
            /// <item><description><b>LOW</b>: Low risk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The solution information for the check item.</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public ListCheckItemsResponseBodyCheckItemsSolution Solution { get; set; }
            public class ListCheckItemsResponseBodyCheckItemsSolution : TeaModel {
                /// <summary>
                /// <para>The type of the check item solution information. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>：Text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The content of the solution for the check item risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test solution.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The status of the check item. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>EDIT</b>: In editing</description></item>
            /// <item><description><b>RELEASE</b>: Released</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EDIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>Page information for paginated queries.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemsResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Number of data entries displayed on the current page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when performing a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of records displayed per page when performing a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of data entries found.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request, which is a unique identifier generated by Alibaba Cloud for this request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
