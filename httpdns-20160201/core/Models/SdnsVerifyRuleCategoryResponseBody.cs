// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class SdnsVerifyRuleCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the matched rule. If no rules are matched, this field is empty or omitted. This field does not represent the final response of the actual resolution chain.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SdnsVerifyRuleCategoryResponseBodyData Data { get; set; }
        public class SdnsVerifyRuleCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom parameter names and their display order. This field can be empty if no custom parameters are used.</para>
            /// </summary>
            [NameInMap("ArgKeys")]
            [Validation(Required=false)]
            public List<string> ArgKeys { get; set; }

            /// <summary>
            /// <para>The custom parameter match conditions attached to the rule. If not configured, no parameter restrictions are attached.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public Dictionary<string, string> Args { get; set; }

            /// <summary>
            /// <para>The rule name, used to identify the rule. This field cannot replace the policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of configured DNS records, which can include A and AAAA records. Actual DNS resolution returns only records of the queried type. If the list is empty or does not contain records of the queried type, the system continues to fall back. This operation returns the records configured in the rule and does not filter them by query type.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<SdnsVerifyRuleCategoryResponseBodyDataRecords> Records { get; set; }
            public class SdnsVerifyRuleCategoryResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The single destination IP address for the record. If Type is set to 1, specify an IPv4 address, such as 192.0.2.200. If Type is set to 28, specify an IPv6 address, such as 2001:db8::200. Do not use CIDR blocks, start-to-end ranges, or domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.200</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The DNS record type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: A record</description></item>
                /// <item><description>28: AAAA record
                /// Specify an integer. Do not use the strings A or AAAA.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The auxiliary display text for the record type. This parameter does not participate in matching or resolution decisions and can be omitted in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("TypeLabel")]
                [Validation(Required=false)]
                public string TypeLabel { get; set; }

                /// <summary>
                /// <para>The relative weight of the record. This parameter is used to select one record of the same query type only when ResultMode is set to 1. Set this parameter to a positive integer from 1 to 100. The sum of the weights of all records does not need to be 100. This parameter does not participate in selection when ResultMode is set to 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The record return mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Returns all records of the queried type.</description></item>
            /// <item><description>1: Returns one record of the queried type based on weight.
            /// Policy validation only returns the rule configuration and does not perform weight sampling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultMode")]
            [Validation(Required=false)]
            public int? ResultMode { get; set; }

            /// <summary>
            /// <para>The cache validity period of the record, in seconds. This parameter must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, used to troubleshoot call issues. This field is not the policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
