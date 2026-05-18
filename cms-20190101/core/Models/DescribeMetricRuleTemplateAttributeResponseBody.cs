// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F3A82AD-DA92-52B0-8EC6-C059D1C3839F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the alert template.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMetricRuleTemplateAttributeResponseBodyResource Resource { get; set; }
        public class DescribeMetricRuleTemplateAttributeResponseBodyResource : TeaModel {
            [NameInMap("AlertTemplates")]
            [Validation(Required=false)]
            public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates AlertTemplates { get; set; }
            public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplates : TeaModel {
                [NameInMap("AlertTemplate")]
                [Validation(Required=false)]
                public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate> AlertTemplate { get; set; }
                public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplate : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Escalations")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations Escalations { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalations : TeaModel {
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical Critical { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsCritical : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo Info { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsInfo : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn Warn { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateEscalationsWarn : TeaModel {
                            [NameInMap("ComparisonOperator")]
                            [Validation(Required=false)]
                            public string ComparisonOperator { get; set; }

                            [NameInMap("Statistics")]
                            [Validation(Required=false)]
                            public string Statistics { get; set; }

                            [NameInMap("Threshold")]
                            [Validation(Required=false)]
                            public string Threshold { get; set; }

                            [NameInMap("Times")]
                            [Validation(Required=false)]
                            public int? Times { get; set; }

                        }

                    }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels Labels { get; set; }
                    public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabels : TeaModel {
                        [NameInMap("Labels")]
                        [Validation(Required=false)]
                        public List<DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels> Labels { get; set; }
                        public class DescribeMetricRuleTemplateAttributeResponseBodyResourceAlertTemplatesAlertTemplateLabelsLabels : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("NoDataPolicy")]
                    [Validation(Required=false)]
                    public string NoDataPolicy { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Selector")]
                    [Validation(Required=false)]
                    public string Selector { get; set; }

                    [NameInMap("SilenceTime")]
                    [Validation(Required=false)]
                    public int? SilenceTime { get; set; }

                    [NameInMap("Webhook")]
                    [Validation(Required=false)]
                    public string Webhook { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the alert template.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Template1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }

            /// <summary>
            /// <para>The ID of the alert template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
