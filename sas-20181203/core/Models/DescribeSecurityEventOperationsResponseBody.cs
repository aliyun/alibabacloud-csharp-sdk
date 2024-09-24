// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A2000F-497E-5DA0-B14D-615CD410DD7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array consisting of the operations that you can perform to handle the alert event.</para>
        /// </summary>
        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            [NameInMap("MappingMarkFields")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMappingMarkFields> MappingMarkFields { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMappingMarkFields : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FillType")]
                [Validation(Required=false)]
                public string FillType { get; set; }

                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                [NameInMap("ShowValue")]
                [Validation(Required=false)]
                public string ShowValue { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>An array consisting of the configuration information that is used when the value of the OperationCode parameter is <b>advance_mark_mis_info</b>.</para>
            /// </summary>
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
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
                /// <para>gmtModified</para>
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
                /// <para>An array consisting of the operations that are supported by the method to add the alert event to the whitelist.</para>
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

                /// <summary>
                /// <para>The UUID of the server on which the alert event is detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3d6b4a75-c28f-447b-9142-38f6252c****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>An array consisting of the configuration items that can be used when the value of the OperationCode parameter is advance_mark_mis_info.</para>
            /// </summary>
            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
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
                /// <para>gmtModified</para>
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
                /// <para>An array consisting of the operations that are supported by the method to add the alert event to the whitelist.</para>
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// <para>The operation that you can perform to handle the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block_ip</b>: blocks the source IP address.</description></item>
            /// <item><description><b>advance_mark_mis_info</b>: adds the alert to the whitelist.</description></item>
            /// <item><description><b>ignore</b>: ignores the alert.</description></item>
            /// <item><description><b>manual_handled</b>: marks the alert as manually handled.</description></item>
            /// <item><description><b>kill_process</b>: terminates the malicious process.</description></item>
            /// <item><description><b>cleanup</b>: performs in-depth virus detection and removal.</description></item>
            /// <item><description><b>kill_and_quara</b>: terminates the malicious process and quarantines the source file.</description></item>
            /// <item><description><b>disable_malicious_defense</b>: stops the container on which the alerting files or processes exist.</description></item>
            /// <item><description><b>client_problem_check</b>: performs troubleshooting.</description></item>
            /// <item><description><b>quara</b>: quarantines the source file of the malicious process.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>advance_mark_mis_info</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The configuration of the operation that you can perform to handle the alert event.</para>
            /// <remarks>
            /// <para> If the value of the OperationCode parameter is <c>kill_and_quara</c> or <c>block_ip</c>, the OperationParams parameter is required. If the value of the OperationCode parameter is a different value, the OperationParams parameter can be left empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expireTime&quot;:1641566807783}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <para>Indicates whether you can handle the alert event in the current edition of Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
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
