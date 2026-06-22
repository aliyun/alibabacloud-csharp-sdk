// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of data collection configurations for the proxy cluster.</para>
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<DescribeHybridProxyPolicyResponseBodyPolicyList> PolicyList { get; set; }
        public class DescribeHybridProxyPolicyResponseBodyPolicyList : TeaModel {
            /// <summary>
            /// <para>The policy information.</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public List<DescribeHybridProxyPolicyResponseBodyPolicyListInfo> Info { get; set; }
            public class DescribeHybridProxyPolicyResponseBodyPolicyListInfo : TeaModel {
                /// <summary>
                /// <para>The specific value of the policy configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The file to which the data intercepted by the proxy cluster policy is written.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The configured policy type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>file</b>: file data collection</description></item>
                /// <item><description><b>net</b>: network data collection</description></item>
                /// <item><description><b>process</b>: process data collection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>limitFrequency</b>: collection frequency control</description></item>
            /// <item><description><b>limitBandWidth</b>: collection bandwidth control.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>limitBandWidth</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7A1B40A-7EED-55A0-BCBC-2F83A486F0AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
