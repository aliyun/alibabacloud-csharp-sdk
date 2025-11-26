// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SasRasp20240727.Models
{
    public class DescribeAttacksResponseBody : TeaModel {
        [NameInMap("Attacks")]
        [Validation(Required=false)]
        public List<DescribeAttacksResponseBodyAttacks> Attacks { get; set; }
        public class DescribeAttacksResponseBodyAttacks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/app</para>
            /// </summary>
            [NameInMap("AppDir")]
            [Validation(Required=false)]
            public string AppDir { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>661dece60bb1</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhxy</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Avd")]
            [Validation(Required=false)]
            public string Avd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jar</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public string Confidence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Exist\&quot;: \&quot;false\&quot;}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ContentLength")]
            [Validation(Required=false)]
            public long? ContentLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;All\&quot;: 12, \&quot;Online\&quot;: 9}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HandleStatus")]
            [Validation(Required=false)]
            public int? HandleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1758607200</para>
            /// </summary>
            [NameInMap("HandleTimestamp")]
            [Validation(Required=false)]
            public long? HandleTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;X-Total-Count\&quot;: 1}</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public string Headers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.116.60.78</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hostnames</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("InputParamItemList")]
            [Validation(Required=false)]
            public List<DescribeAttacksResponseBodyAttacksInputParamItemList> InputParamItemList { get; set; }
            public class DescribeAttacksResponseBodyAttacksInputParamItemList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4E7772EA-1AD0-5583-BA55-A4****</para>
                /// </summary>
                [NameInMap("ProcessedKey")]
                [Validation(Required=false)]
                public string ProcessedKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4E7772EA-1AD0-5583-BA55-A4****</para>
                /// </summary>
                [NameInMap("RawKey")]
                [Validation(Required=false)]
                public string RawKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.101.9.189</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InstallType")]
            [Validation(Required=false)]
            public long? InstallType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.92.92.85</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.8.0_342</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("LanguageVersion")]
            [Validation(Required=false)]
            public string LanguageVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727281449756</para>
            /// </summary>
            [NameInMap("MaxTimestamp")]
            [Validation(Required=false)]
            public long? MaxTimestamp { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MiddlewareInstanceId")]
            [Validation(Required=false)]
            public string MiddlewareInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1727281449756</para>
            /// </summary>
            [NameInMap("MinTimestamp")]
            [Validation(Required=false)]
            public long? MinTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OsArch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun_V3_5.1</para>
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC_CLOUD</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>245256</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PayloadLength")]
            [Validation(Required=false)]
            public long? PayloadLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>29719</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>php</para>
            /// </summary>
            [NameInMap("RaspVersion")]
            [Validation(Required=false)]
            public string RaspVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("Remote")]
            [Validation(Required=false)]
            public string Remote { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;TagKey\&quot;: \&quot;acs:rm:rgId\&quot;, \&quot;TagValue\&quot;: \&quot;rg-aek25bwhtt22cjq\&quot;}]</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public string RuleResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Stacktrace")]
            [Validation(Required=false)]
            public List<string> Stacktrace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1724033134746</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1712284140</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>unionId。</para>
            /// 
            /// <b>Example:</b>
            /// <para>23yaet4dg6ek3s7aj</para>
            /// </summary>
            [NameInMap("UnionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/TaxiInvoice_01.jpeg">https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/TaxiInvoice_01.jpeg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E7772EA-1AD0-5583-BA55-A4E7B65F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>289</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
