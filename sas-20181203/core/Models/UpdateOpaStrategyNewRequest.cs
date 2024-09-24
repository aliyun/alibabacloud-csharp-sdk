// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewRequest : TeaModel {
        /// <summary>
        /// <para>The risks that you want to detect by using the rule.</para>
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public UpdateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class UpdateOpaStrategyNewRequestAlarmDetail : TeaModel {
            /// <summary>
            /// <para>The baseline risks.</para>
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                /// <summary>
                /// <para>The baseline check items.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
                    /// <summary>
                    /// <para>The ID of the baseline check item.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2539883.html">GetOpaClusterBaseLineList</a> operation to query the ID.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hc.image.checklist.identify.hc_exploit_couchdb_linux.item</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the baseline check item.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2539883.html">GetOpaClusterBaseLineList</a> operation to query the name.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>passwd</para>
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
            public UpdateOpaStrategyNewRequestAlarmDetailBuildRisk BuildRisk { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBuildRisk : TeaModel {
                /// <summary>
                /// <para>The configuration of image build risk.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBuildRiskItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBuildRiskItem : TeaModel {
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
            /// <para>The malicious sample risks.</para>
            /// </summary>
            [NameInMap("MaliciousFile")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                /// <summary>
                /// <para>The malicious samples.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
                    /// <summary>
                    /// <para>The ID of the malicious sample.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="~~DescribeMatchedMaliciousNames~~">DescribeMatchedMaliciousNames</a> operation to query the ID.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65201</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the malicious sample.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="~~DescribeMatchedMaliciousNames~~">DescribeMatchedMaliciousNames</a> operation to query the name.</para>
                    /// </remarks>
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
            public UpdateOpaStrategyNewRequestAlarmDetailSensitiveFile SensitiveFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailSensitiveFile : TeaModel {
                /// <summary>
                /// <para>The configuration of sensitive file.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailSensitiveFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailSensitiveFileItem : TeaModel {
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
            /// <para>The vulnerability risks.</para>
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                /// <summary>
                /// <para>The vulnerabilities.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
                    /// <summary>
                    /// <para>The ID of the vulnerability.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="https://help.aliyun.com/document_detail/471928.html">DescribeVulListPage</a> operation to query the ID.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CVE-2023-36034</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the vulnerability.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="https://help.aliyun.com/document_detail/471928.html">DescribeVulListPage</a> operation to query the name.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oval:com.redhat.rhsa:def:20227002</para>
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
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulRiskClass> RiskClass { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulRiskClass : TeaModel {
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
        /// <remarks>
        /// <para>This parameter is deprecated. You can use the Scopes parameter to specify a scope in which cluster parameters take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c870ec78ecbcb41d2a35c679823ef****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>docker-law</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The rule description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4566</para>
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
        /// <para>Specifies whether the rule supports malicious Internet images. Valid values:</para>
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
        /// <para>The action that is performed when the rule is hit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: alert</description></item>
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
        public List<UpdateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewRequestScopes : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster node to which the rule is applied.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~GetOpaStrategyDetailNew~~">GetOpaStrategyDetailNew</a> operation to query the ID of the cluster node to which the rule is applied.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ack-1</para>
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether all namespaces are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not all namespaces are included.</description></item>
            /// <item><description><b>1</b>: All namespaces are included.</description></item>
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
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the cluster ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cdcb56a931c**</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The namespaces.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the AllNamespace parameter is set to 0.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2623574.html">ListOpaClusterStrategyNew</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1003</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The ID of the rule template.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2539952.html">GetOpaStrategyTemplateSummary</a> operation to query the ID of the rule template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>109</para>
        /// </summary>
        [NameInMap("StrategyTemplateId")]
        [Validation(Required=false)]
        public long? StrategyTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule supports unscanned images. Valid values:</para>
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
        /// <para>The whitelists.</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
