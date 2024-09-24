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
        /// <para>The operation performed on the alert event.</para>
        /// </summary>
        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            /// <summary>
            /// <para>The object on which the operation is performed. This parameter is required when you set the OperationCode parameter to <b>advance_mark_mis_info</b>.</para>
            /// </summary>
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
                /// <summary>
                /// <para>The alias of the field that is used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file path</para>
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// <para>The field that is used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filePath</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// <para>The operation that is used in the whitelist rule. Valid values:</para>
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
                /// <para>The value of the field that is used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-25 10:11:04</para>
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// <para>The operation that is used and can be modified in the whitelist rule. Valid values:</para>
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
            /// <para>The metadata configuration returned by the advanced whitelist rule.</para>
            /// </summary>
            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
                /// <summary>
                /// <para>The alias of the field that can be used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file path</para>
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// <para>The field that can be used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filePath</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// <para>The value of the field that can be used in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// <para>The operation that is supported in the whitelist rule. Valid values:</para>
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
            /// <para>The operation performed to handle the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block_ip</b>: blocks the alert.</description></item>
            /// <item><description><b>advance_mark_mis_info</b>: adds the alert to the whitelist.</description></item>
            /// <item><description><b>ignore</b>: ignores the alert.</description></item>
            /// <item><description><b>manual_handled</b>: marks the alert as manually handled.</description></item>
            /// <item><description><b>kill_process</b>: terminates the malicious process.</description></item>
            /// <item><description><b>cleanup</b>: performs in-depth virus detection and removal.</description></item>
            /// <item><description><b>kill_and_quara</b>: performs virus detection and removal.</description></item>
            /// <item><description><b>disable_malicious_defense</b>: turns off malicious defense behavior.</description></item>
            /// <item><description><b>client_problem_check</b>: performs troubleshooting.</description></item>
            /// <item><description><b>quara</b>: performs quarantine operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>advance_mark_mis_info</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The configuration of the operation performed to handle the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;subOperation\&quot;:\&quot;killByMd5andPath\&quot;}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation can be performed.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The operation can be performed.</description></item>
            /// <item><description><b>false</b>: The operation cannot be performed.</description></item>
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
