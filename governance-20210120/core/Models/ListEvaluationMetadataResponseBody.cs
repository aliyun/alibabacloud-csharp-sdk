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
                /// 
                /// <b>Example:</b>
                /// <para>If you use an AccessKey pair of an Alibaba Cloud account, you have full permissions on the resources of the account. You cannot set limits on the account, such as setting limits on source IP addresses or access duration. If the AccessKey pair is leaked, resources within the account are exposed to high security risks. If your Alibaba Cloud account has an existing AccessKey pair, the check result is Non-compliant.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AccessKey pair is enabled for the Alibaba Cloud account.</para>
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
                            /// 
                            /// <b>Example:</b>
                            /// <para>You are not charged for this operation.</para>
                            /// </summary>
                            [NameInMap("CostDescription")]
                            [Validation(Required=false)]
                            public string CostDescription { get; set; }

                            /// <summary>
                            /// <para>The description of the fixing item.</para>
                            /// <remarks>
                            /// <para> This parameter is returned only if the value of <c>RemediationType</c> is <c>Analysis</c>.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Console logon is enabled for the RAM user. The RAM user owns an AccessKey pair that is never used.</para>
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
                                /// 
                                /// <b>Example:</b>
                                /// <para>Manual fixing</para>
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
                                /// 
                                /// <b>Example:</b>
                                /// <para>You must replace the AccessKey pair of your Alibaba Cloud account. To do so, perform the following steps:</br>1. Log on to the RAM console. In the left-side navigation pane, choose Identities &gt; Users. On the Users page, click Create User.</br>2. On the Create User page, enter a logon name and select OpenAPI Access for the Access Mode parameter.</br>3. After the RAM user is created, save the AccessKey pair. Then, find the user that you created on the Users page and click Add Permissions in the Actions column. In the Grant Permission panel, find the AdministratorAccess policy and attach it to the RAM user.</br>4. In a program, replace the AccessKey pair of the Alibaba Cloud account with the AccessKey pair of the RAM user created in the previous step and check whether the program runs as expected in the test environment.</br>5. If the program runs as expected, publish the program to the production environment and disable the previous AccessKey pair of your Alibaba Cloud account. Then, check whether the program runs as expected.</br>6. If the program runs as expected, delete the disabled AccessKey pair after the specified period of time, such as 90 days.</para>
                                /// </summary>
                                [NameInMap("Content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The title of the fixing procedure.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Scenario 3: AccessKey pair that is used within the last 90 days</para>
                                /// </summary>
                                [NameInMap("Title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The usage notes of the fixing item.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The BestPracticesForIdentityAndPermissions compliance package is enabled in Cloud Config to check the settings and usage of the AccessKey pair, Alibaba Cloud account, and RAM users.</para>
                            /// </summary>
                            [NameInMap("Notice")]
                            [Validation(Required=false)]
                            public string Notice { get; set; }

                            /// <summary>
                            /// <para>The fixing suggestion.</para>
                            /// <remarks>
                            /// <para> This parameter is returned only if the value of <c>RemediationType</c> is <c>Analysis</c>.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Console logon is enabled for the RAM user and the RAM user owns an AccessKey pair, while the AccessKey pair has never been used by the RAM user. We recommend that you disable the AccessKey pair for 90 days. If no related issue occurs during this period, you can delete the AccessKey pair.</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>AccessKey Pair Last Used At</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>ResourceUtilization</para>
                /// </summary>
                [NameInMap("TopicCode")]
                [Validation(Required=false)]
                public string TopicCode { get; set; }

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
