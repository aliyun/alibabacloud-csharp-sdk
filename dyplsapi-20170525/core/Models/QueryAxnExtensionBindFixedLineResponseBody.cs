// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxnExtensionBindFixedLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The API request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Success.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/59892.html">API error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of binding objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAxnExtensionBindFixedLineResponseBodyData> Data { get; set; }
        public class QueryAxnExtensionBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ringback tone code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002,10003</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>The ringback tone played to the called party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002</para>
            /// </summary>
            [NameInMap("Anucodecalled")]
            [Validation(Required=false)]
            public string Anucodecalled { get; set; }

            /// <summary>
            /// <para>The area code of the private number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571</para>
            /// </summary>
            [NameInMap("Areacode")]
            [Validation(Required=false)]
            public string Areacode { get; set; }

            /// <summary>
            /// <para>The expiration time, in seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: never expires.</para>
            /// </description></item>
            /// <item><description><para>Other values: the binding is valid for the specified duration after the X number is successfully assigned. For example, if the value is 60, the binding is valid for 60 seconds and is automatically unbound after 60 seconds.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The extension fields.</para>
            /// </summary>
            [NameInMap("Extraaxx")]
            [Validation(Required=false)]
            public QueryAxnExtensionBindFixedLineResponseBodyDataExtraaxx Extraaxx { get; set; }
            public class QueryAxnExtensionBindFixedLineResponseBodyDataExtraaxx : TeaModel {
                /// <summary>
                /// <para>The callback control. Number A calls through X, meaning A is the caller and X is the callee. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): outbound calls are not allowed.</para>
                /// </description></item>
                /// <item><description><para>1: connects to the most recent number N.</para>
                /// </description></item>
                /// <item><description><para>2: calls back the fixed number TelB.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>The recording control. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): recording is disabled.</para>
                /// </description></item>
                /// <item><description><para>1: recording is enabled.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>After the call recording feature is enabled, you can play and download voice files in the call records. Recording files are billed at 0.010 CNY per minute.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Callrecording")]
                [Validation(Required=false)]
                public string Callrecording { get; set; }

            }

            /// <summary>
            /// <para>The external business extension field. This parameter is returned in the call record receipt message. The value cannot exceed 100 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19394</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The binding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A203**************</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>The binding time, in the format of yyyyMMddHHmmss. The time is in UTC+8, in 24-hour format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20161114143116</para>
            /// </summary>
            [NameInMap("Subts")]
            [Validation(Required=false)]
            public string Subts { get; set; }

            /// <summary>
            /// <para>The ringback tone code played to the caller after the call is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002</para>
            /// </summary>
            [NameInMap("TAnucodeConnect")]
            [Validation(Required=false)]
            public string TAnucodeConnect { get; set; }

            /// <summary>
            /// <para>The number A.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155****1111</para>
            /// </summary>
            [NameInMap("TelA")]
            [Validation(Required=false)]
            public string TelA { get; set; }

            /// <summary>
            /// <para>The private number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571******23</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

            /// <summary>
            /// <para>The extension number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009</para>
            /// </summary>
            [NameInMap("TelXext")]
            [Validation(Required=false)]
            public string TelXext { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74EFA0E8-CFCA-54D9-BFE5-904F9FA88DBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
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
