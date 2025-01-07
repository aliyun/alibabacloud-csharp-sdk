// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The data collection configurations of the proxy cluster.</para>
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<DescribeHybridProxyPolicyResponseBodyPolicyList> PolicyList { get; set; }
        public class DescribeHybridProxyPolicyResponseBodyPolicyList : TeaModel {
            /// <summary>
            /// <para>The information about the policy.</para>
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public List<DescribeHybridProxyPolicyResponseBodyPolicyListInfo> Info { get; set; }
            public class DescribeHybridProxyPolicyResponseBodyPolicyListInfo : TeaModel {
                /// <summary>
                /// <para>The value of the policy configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The name of the file. After you configure a blocking policy, the blocked data is written to the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The type of the policy that you configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>net</b></description></item>
                /// <item><description><b>process</b></description></item>
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
            /// <para>The type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>limitFrequency</b></description></item>
            /// <item><description><b>limitBandWidth</b></description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7A1B40A-7EED-55A0-BCBC-2F83A486F0AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
