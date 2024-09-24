// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaStrategyDetailNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOpaStrategyDetailNewResponseBodyData Data { get; set; }
        public class GetOpaStrategyDetailNewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rule configuration.</para>
            /// </summary>
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetOpaStrategyDetailNewResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetail : TeaModel {
                /// <summary>
                /// <para>The baseline check configuration.</para>
                /// </summary>
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline : TeaModel {
                    /// <summary>
                    /// <para>The information about the baseline check item.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the baseline check item.</para>
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
                    /// <para>The risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration of image build risk.</para>
                /// </summary>
                [NameInMap("BuildRisk")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk BuildRisk { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk : TeaModel {
                    /// <summary>
                    /// <para>The configuration of image build risk.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the image build risk.</para>
                        /// <remarks>
                        /// <para> You can call the <a href="~~ListImageBuildRiskItem~~">ListImageBuildRiskItem</a> operation to query the ID of the malicious sample.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the image build risk.</para>
                        /// <remarks>
                        /// <para> You can call the <a href="~~ListImageBuildRiskItem~~">ListImageBuildRiskItem</a> operation to query the ID of the malicious sample.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration of malicious samples.</para>
                /// </summary>
                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    /// <summary>
                    /// <para>The information about the malicious sample.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the malicious sample.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1811</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the malicious sample.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>abnormal binary file</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration of sensitive file.</para>
                /// </summary>
                [NameInMap("SensitiveFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile SensitiveFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile : TeaModel {
                    /// <summary>
                    /// <para>The configuration of sensitive file.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the sensitive files.</para>
                        /// <remarks>
                        /// <para> You can call the <a href="~~GetSensitiveDefineRuleConfig~~">GetSensitiveDefineRuleConfig</a> operation to query the ID of the malicious sample.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the sensitive files.</para>
                        /// <remarks>
                        /// <para> You can call the <a href="~~GetSensitiveDefineRuleConfig~~">GetSensitiveDefineRuleConfig</a> operation to query the ID of the malicious sample.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The vulnerability configuration.</para>
                /// </summary>
                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul : TeaModel {
                    /// <summary>
                    /// <para>The information about the vulnerability.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem : TeaModel {
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
                        /// <para>The name of the vulnerability.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ezOffice evoInterfaceServlet Info Leak</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>Risk type of vulnerability.</para>
                    /// </summary>
                    [NameInMap("RiskClass")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass> RiskClass { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass : TeaModel {
                        /// <summary>
                        /// <para>The ID of the vulnerability types. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>cve</b>: system vulnerability</description></item>
                        /// <item><description><b>app</b>: application vulnerability</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cve</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the vulnerability. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>system vulnerability</b></description></item>
                        /// <item><description><b>application vulnerability</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>system vulnerability</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk levels.</para>
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
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The page number. Default value: <b>1</b>. Pages start from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom defense configuration</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image names.</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// <para>The image tags.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule supports malicious Internet images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The action that is performed when the rule is hit. Valid values:</para>
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
            /// <para>The application scope.</para>
            /// </summary>
            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<GetOpaStrategyDetailNewResponseBodyDataScopes> Scopes { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataScopes : TeaModel {
                /// <summary>
                /// <para>The rule instance ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack-0</para>
                /// </summary>
                [NameInMap("AckPolicyInstanceId")]
                [Validation(Required=false)]
                public string AckPolicyInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether all namespaces are included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1fdb5fd8d**7163</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The namespaces.</para>
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

            }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1005</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The ID of the rule template.</para>
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

            /// <summary>
            /// <para>The image tags that are added to the whitelist.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E819FD71-D240-5E54-AA7F-20FED2ECBEB6</para>
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
