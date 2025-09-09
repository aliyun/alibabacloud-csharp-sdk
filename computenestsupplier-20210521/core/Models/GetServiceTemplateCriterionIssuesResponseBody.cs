// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceTemplateCriterionIssuesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A361BA9E-xxxx-xxxx-xxxx-C26E5180456E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskyTemplateCount")]
        [Validation(Required=false)]
        public int? RiskyTemplateCount { get; set; }

        [NameInMap("TemplateCriterionIssueList")]
        [Validation(Required=false)]
        public List<GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueList> TemplateCriterionIssueList { get; set; }
        public class GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueList : TeaModel {
            [NameInMap("CriterionIssues")]
            [Validation(Required=false)]
            public List<GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueListCriterionIssues> CriterionIssues { get; set; }
            public class GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueListCriterionIssues : TeaModel {
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueListCriterionIssuesExtendInfo ExtendInfo { get; set; }
                public class GetServiceTemplateCriterionIssuesResponseBodyTemplateCriterionIssueListCriterionIssuesExtendInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ChargeType</para>
                    /// </summary>
                    [NameInMap("AssociationProperty")]
                    [Validation(Required=false)]
                    public string AssociationProperty { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Property")]
                    [Validation(Required=false)]
                    public string Property { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mandatory</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>$.Parameters.PayType</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ParameterNeedAssociationProperty</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://service-private-info/xxx/ros/template/tpl-xxxx.json">http://service-private-info/xxx/ros/template/tpl-xxxx.json</a></para>
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public int? TemplateUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCriterionIssueCount")]
            [Validation(Required=false)]
            public int? TotalCriterionIssueCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalMandatoryCriterionIssueCount")]
            [Validation(Required=false)]
            public int? TotalMandatoryCriterionIssueCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCriterionIssueCount")]
        [Validation(Required=false)]
        public int? TotalCriterionIssueCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalMandatoryCriterionIssueCount")]
        [Validation(Required=false)]
        public int? TotalMandatoryCriterionIssueCount { get; set; }

    }

}
