// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AdvanceSecurityEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The operation types for handling alert events.</para>
        /// </summary>
        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            /// <summary>
            /// <para>The configuration information when the handling method is <b>advance_mark_mis_info</b>.</para>
            /// </summary>
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
                /// <summary>
                /// <para>The name of the whitelist field in the configured whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file path</para>
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// <para>The whitelist field in the configured whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filePath</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// <para>The wildcard in the configured whitelist rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>contains</b>: contains</description></item>
                /// <item><description><b>notContains</b>: does not contain</description></item>
                /// <item><description><b>regex</b>: regular expression</description></item>
                /// <item><description><b>strEqual</b>: equals</description></item>
                /// <item><description><b>strNotEqual</b>: does not equal</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("MarkMisType")]
                [Validation(Required=false)]
                public string MarkMisType { get; set; }

                /// <summary>
                /// <para>The rule value of the configured whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-25 10:11:04</para>
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// <para>The wildcard types that can be modified in the configured whitelist rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>contains</b>: contains</description></item>
                /// <item><description><b>notContains</b>: does not contain</description></item>
                /// <item><description><b>regex</b>: regular expression</description></item>
                /// <item><description><b>strEqual</b>: equals</description></item>
                /// <item><description><b>strNotEqual</b>: does not equal</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// <para>The metadata configuration information returned for the advanced whitelist.</para>
            /// </summary>
            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
                /// <summary>
                /// <para>The name of the whitelist field that can be configured in a whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file path</para>
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// <para>The whitelist field that can be configured in a whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filePath</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// <para>The rule value of the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// <para>The supported wildcards in the whitelist rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>contains</b>: contains</description></item>
                /// <item><description><b>notContains</b>: does not contain</description></item>
                /// <item><description><b>regex</b>: regular expression</description></item>
                /// <item><description><b>strEqual</b>: equals</description></item>
                /// <item><description><b>strNotEqual</b>: does not equal</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// <para>The handling method for the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block_ip</b>: Block.</description></item>
            /// <item><description><b>advance_mark_mis_info</b>: Add to whitelist.</description></item>
            /// <item><description><b>ignore</b>: Ignore.</description></item>
            /// <item><description><b>manual_handled</b>: Manually handled.</description></item>
            /// <item><description><b>kill_process</b>: Terminate process.</description></item>
            /// <item><description><b>cleanup</b>: Deep scan and removal.</description></item>
            /// <item><description><b>kill_and_quara</b>: Virus scan and quarantine.</description></item>
            /// <item><description><b>disable_malicious_defense</b>: Disable malicious behavior defense.</description></item>
            /// <item><description><b>client_problem_check</b>: Troubleshoot.</description></item>
            /// <item><description><b>quara</b>: Quarantine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>advance_mark_mis_info</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The configuration of the sub-operation for the alert event handling method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;subOperation\&quot;:\&quot;killByMd5andPath\&quot;}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation is available.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Available.</description></item>
            /// <item><description><b>false</b>: Not available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UserCanOperate")]
            [Validation(Required=false)]
            public bool? UserCanOperate { get; set; }

        }

    }

}
