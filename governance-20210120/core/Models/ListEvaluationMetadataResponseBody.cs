// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of a governance maturity check.</para>
        /// </summary>
        [NameInMap("EvaluationMetadata")]
        [Validation(Required=false)]
        public List<ListEvaluationMetadataResponseBodyEvaluationMetadata> EvaluationMetadata { get; set; }
        public class ListEvaluationMetadataResponseBodyEvaluationMetadata : TeaModel {
            /// <summary>
            /// <para>The metadata objects of a specific metadata type.</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadata> Metadata { get; set; }
            public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadata : TeaModel {
                /// <summary>
                /// <para>The category of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Security</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The description of the check item.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the check item.</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxgtda****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The governance level of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>High</para>
                /// </summary>
                [NameInMap("RecommendationLevel")]
                [Validation(Required=false)]
                public string RecommendationLevel { get; set; }

                /// <summary>
                /// <para>The metadata of the fixing task.</para>
                /// </summary>
                [NameInMap("RemediationMetadata")]
                [Validation(Required=false)]
                public ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadata RemediationMetadata { get; set; }
                public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadata : TeaModel {
                    /// <summary>
                    /// <para>The fixing items.</para>
                    /// </summary>
                    [NameInMap("Remediation")]
                    [Validation(Required=false)]
                    public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediation> Remediation { get; set; }
                    public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediation : TeaModel {
                        /// <summary>
                        /// <para>The fixing operations.</para>
                        /// </summary>
                        [NameInMap("Actions")]
                        [Validation(Required=false)]
                        public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActions> Actions { get; set; }
                        public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActions : TeaModel {
                            /// <summary>
                            /// <para>The fixing method.</para>
                            /// <remarks>
                            /// <para> This parameter is returned only if the value of <c>RemediationType</c> is <c>Analysis</c>.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>UnusedAccessKeyInRamUser</para>
                            /// </summary>
                            [NameInMap("Classification")]
                            [Validation(Required=false)]
                            public string Classification { get; set; }

                            /// <summary>
                            /// <para>The fixing cost.</para>
                            /// </summary>
                            [NameInMap("CostDescription")]
                            [Validation(Required=false)]
                            public string CostDescription { get; set; }

                            /// <summary>
                            /// <para>The description of the fixing item.</para>
                            /// <remarks>
                            /// <para> This parameter is returned only if the value of <c>RemediationType</c> is <c>Analysis</c>.</para>
                            /// </remarks>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The content of the fixing items.</para>
                            /// </summary>
                            [NameInMap("Guidance")]
                            [Validation(Required=false)]
                            public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActionsGuidance> Guidance { get; set; }
                            public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataRemediationMetadataRemediationActionsGuidance : TeaModel {
                                /// <summary>
                                /// <para>The display name of the fixing button.</para>
                                /// </summary>
                                [NameInMap("ButtonName")]
                                [Validation(Required=false)]
                                public string ButtonName { get; set; }

                                /// <summary>
                                /// <para>The navigation URL of the fixing button.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="https://ram.console.aliyun.com/users">https://ram.console.aliyun.com/users</a></para>
                                /// </summary>
                                [NameInMap("ButtonRef")]
                                [Validation(Required=false)]
                                public string ButtonRef { get; set; }

                                /// <summary>
                                /// <para>The fixing procedure.</para>
                                /// </summary>
                                [NameInMap("Content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The title of the fixing procedure.</para>
                                /// </summary>
                                [NameInMap("Title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The usage notes of the fixing item.</para>
                            /// </summary>
                            [NameInMap("Notice")]
                            [Validation(Required=false)]
                            public string Notice { get; set; }

                            /// <summary>
                            /// <para>The fixing suggestion.</para>
                            /// <remarks>
                            /// <para> This parameter is returned only if the value of <c>RemediationType</c> is <c>Analysis</c>.</para>
                            /// </remarks>
                            /// </summary>
                            [NameInMap("Suggestion")]
                            [Validation(Required=false)]
                            public string Suggestion { get; set; }

                        }

                        /// <summary>
                        /// <para>The type of the fixing method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Manual: manual fixing</description></item>
                        /// <item><description>QuickFix: quick fixing</description></item>
                        /// <item><description>Analysis: auxiliary decision-making</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Manual</para>
                        /// </summary>
                        [NameInMap("RemediationType")]
                        [Validation(Required=false)]
                        public string RemediationType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metadata of the checked resources.</para>
                /// </summary>
                [NameInMap("ResourceMetadata")]
                [Validation(Required=false)]
                public ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadata ResourceMetadata { get; set; }
                public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadata : TeaModel {
                    /// <summary>
                    /// <para>The metadata of the resource properties.</para>
                    /// </summary>
                    [NameInMap("ResourcePropertyMetadata")]
                    [Validation(Required=false)]
                    public List<ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadataResourcePropertyMetadata> ResourcePropertyMetadata { get; set; }
                    public class ListEvaluationMetadataResponseBodyEvaluationMetadataMetadataResourceMetadataResourcePropertyMetadata : TeaModel {
                        /// <summary>
                        /// <para>The display name of the resource property.</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>The name of the resource property.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AkLastUsedTime</para>
                        /// </summary>
                        [NameInMap("PropertyName")]
                        [Validation(Required=false)]
                        public string PropertyName { get; set; }

                        /// <summary>
                        /// <para>The type of the resource property.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>String</para>
                        /// </summary>
                        [NameInMap("PropertyType")]
                        [Validation(Required=false)]
                        public string PropertyType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The scope of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Account: the check item in a single-account governance maturity check</description></item>
                /// <item><description>ResourceDirectory: the check item in a multi-account governance maturity check</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Account</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The status of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Released: The check item is released.</description></item>
                /// <item><description>Beta: The check item is pre-released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Released</para>
                /// </summary>
                [NameInMap("Stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

            }

            /// <summary>
            /// <para>The type of the metadata. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Metric: the check item</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Metric</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16B208DD-86BD-5E7D-AC93-FFD44B6FBDF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
