// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaStrategyDetailNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success, whereas any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOpaStrategyDetailNewResponseBodyData Data { get; set; }
        public class GetOpaStrategyDetailNewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The policy configuration information.</para>
            /// </summary>
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetOpaStrategyDetailNewResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetail : TeaModel {
                /// <summary>
                /// <para>The baseline configuration information.</para>
                /// </summary>
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline : TeaModel {
                    /// <summary>
                    /// <para>The baseline item information.</para>
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
                    /// <para>The list of risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The information about risky image build commands.</para>
                /// </summary>
                [NameInMap("BuildRisk")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk BuildRisk { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk : TeaModel {
                    /// <summary>
                    /// <para>The list of risk items.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the risky image build command type.</para>
                        /// <remarks>
                        /// <para>You can call the <a href="~~ListImageBuildRiskItem~~">ListImageBuildRiskItem</a> operation to query this value.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the risky image build command type.</para>
                        /// <remarks>
                        /// <para>You can call the <a href="~~ListImageBuildRiskItem~~">ListImageBuildRiskItem</a> operation to query this value.</para>
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
                    /// <para>The list of risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The configuration information for malicious samples.</para>
                /// </summary>
                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    /// <summary>
                    /// <para>The information about malicious sample items.</para>
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
                    /// <para>The list of risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The information about sensitive files.</para>
                /// </summary>
                [NameInMap("SensitiveFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile SensitiveFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile : TeaModel {
                    /// <summary>
                    /// <para>The list of sensitive file check items.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the sensitive file type.</para>
                        /// <remarks>
                        /// <para>You can call the <a href="~~GetSensitiveDefineRuleConfig~~">GetSensitiveDefineRuleConfig</a> operation to query this value.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the sensitive file type.</para>
                        /// <remarks>
                        /// <para>You can call the <a href="~~GetSensitiveDefineRuleConfig~~">GetSensitiveDefineRuleConfig</a> operation to query this value.</para>
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
                    /// <para>The list of risk levels.</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The vulnerability configuration information.</para>
                /// </summary>
                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul : TeaModel {
                    /// <summary>
                    /// <para>The information about vulnerability items.</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem : TeaModel {
                        /// <summary>
                        /// <para>The vulnerability ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AVD-2023-1680169</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The vulnerability name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ezOffice evoInterfaceServlet Info Leak</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of vulnerability types.</para>
                    /// </summary>
                    [NameInMap("RiskClass")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass> RiskClass { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass : TeaModel {
                        /// <summary>
                        /// <para>The ID of the vulnerability type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>cve</b>: System vulnerability.</description></item>
                        /// <item><description><b>app</b>: Application vulnerability.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cve</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the vulnerability type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>System vulnerability</b></description></item>
                        /// <item><description><b>Application vulnerability</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>System vulnerability</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of risk levels.</para>
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
            /// <para>The page number from which to display the query results. Default value: <b>1</b>.</para>
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
            /// <para>The image name.</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// <para>The image label.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese.</description></item>
            /// <item><description><b>en</b>: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy supports malicious images from the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries to return per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The action to perform when the policy is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Alert.</description></item>
            /// <item><description><b>2</b>: Block.</description></item>
            /// <item><description><b>3</b>: Allow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// <para>The scope.</para>
            /// </summary>
            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<GetOpaStrategyDetailNewResponseBodyDataScopes> Scopes { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataScopes : TeaModel {
                /// <summary>
                /// <para>The policy instance ID in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack-0</para>
                /// </summary>
                [NameInMap("AckPolicyInstanceId")]
                [Validation(Required=false)]
                public string AckPolicyInstanceId { get; set; }

                /// <summary>
                /// <para>Specifies whether all namespaces are included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Yes.</description></item>
                /// <item><description><b>0</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1fdb5fd8d**7163</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The list of namespaces.</para>
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

            }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1005</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The ID of the policy template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1204</para>
            /// </summary>
            [NameInMap("StrategyTemplateId")]
            [Validation(Required=false)]
            public long? StrategyTemplateId { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy supports unscanned images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

            /// <summary>
            /// <para>The whitelist of image tags.</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E819FD71-D240-5E54-AA7F-20FED2ECBEB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
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
