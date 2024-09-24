// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetStrategyTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the template.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStrategyTemplateDetailResponseBodyData Data { get; set; }
        public class GetStrategyTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration of the rule.</para>
            /// </summary>
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetStrategyTemplateDetailResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetStrategyTemplateDetailResponseBodyDataAlarmDetail : TeaModel {
                /// <summary>
                /// <para>The configuration of the baseline.</para>
                /// </summary>
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline : TeaModel {
                    /// <summary>
                    /// <para>The baseline items.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem : TeaModel {
                        /// <summary>
                        /// <para>The unique identifier of the baseline check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ak_leak</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the baseline check item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Access Key plaintext storage</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The severities of the baselines. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>high</b></description></item>
                    /// <item><description><b>medium</b></description></item>
                    /// <item><description><b>low</b></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the alert rule for the malicious sample.</para>
                /// </summary>
                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    /// <summary>
                    /// <para>The items on which malicious samples are detected.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
                        /// <summary>
                        /// <para>The unique identifier of the malicious sample.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the malicious sample.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The severities of the malicious samples.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the vulnerability detection rule.</para>
                /// </summary>
                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul : TeaModel {
                    /// <summary>
                    /// <para>The items on which vulnerabilities are detected.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the vulnerability.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AVD-2023-1680169</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The alias of the vulnerability.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ezOffice evoInterfaceServlet Info Leak</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The severities of the vulnerabilities.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

            }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hhht-cluster-02</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom defense configuration</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The names of images.</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// <para>The tags that are added to the containers.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule supports malicious Internet images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            /// <summary>
            /// <para>The namespaces.</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<string> Namespace { get; set; }

            /// <summary>
            /// <para>The action on requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: trigger alerts</description></item>
            /// <item><description><b>2</b>: block</description></item>
            /// <item><description><b>3</b>: allow</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1005</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Blank template</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1204</para>
            /// </summary>
            [NameInMap("StrategyTemplateId")]
            [Validation(Required=false)]
            public long? StrategyTemplateId { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule supports unscanned images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

            /// <summary>
            /// <para>The whitelists of tags that are added to images.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E36BEEA-0B27-58CC-8319-50279203B048</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
