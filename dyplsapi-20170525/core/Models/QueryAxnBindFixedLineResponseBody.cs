// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxnBindFixedLineResponseBody : TeaModel {
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
        /// <para>The API request status code. Valid values:
        /// 0: success. For other error codes, see <a href="https://help.aliyun.com/document_detail/59892.html">API error codes</a>.</para>
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
        public List<QueryAxnBindFixedLineResponseBodyData> Data { get; set; }
        public class QueryAxnBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pre-connection ringback tone codes. The value must contain codes for three scenarios, specified in the order of &quot;B-&gt;X, A-&gt;X, other numbers-&gt;X&quot; and separated by commas. </para>
            /// <remarks>
            /// <para>&quot;1,2,3&quot; indicates that the ringback tone code for B-&gt;X is 1, the code for A-&gt;X is 2, and the code for other numbers-&gt;X is 3.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>The ringback tone code for the called party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002</para>
            /// </summary>
            [NameInMap("Anucodecalled")]
            [Validation(Required=false)]
            public string Anucodecalled { get; set; }

            /// <summary>
            /// <para>The area code of the privacy number.</para>
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
            /// <item><description><para>Other values: the binding remains valid for the specified number of seconds after the X phone number is assigned. For example, if the value is 60, the binding expires and is automatically released after 60 seconds.</para>
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
            /// <para>The extended parameters.</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public QueryAxnBindFixedLineResponseBodyDataExtra Extra { get; set; }
            public class QueryAxnBindFixedLineResponseBodyDataExtra : TeaModel {
                /// <summary>
                /// <para>The callback control. A calls X, meaning A is the caller and X is the callee. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): outbound calls are not allowed.</para>
                /// </description></item>
                /// <item><description><para>1: the call is connected to the most recent N phone number.</para>
                /// </description></item>
                /// <item><description><para>2: the call is connected to the fixed phone number TelB.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>The call recording control. Valid values:</para>
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
                /// <para>1</para>
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
            /// <para>GHX**************************</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>The binding time. Format: yyyyMMddHHmmss. The time is in UTC+8, in 24-hour format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20161114143116</para>
            /// </summary>
            [NameInMap("Subts")]
            [Validation(Required=false)]
            public string Subts { get; set; }

            /// <summary>
            /// <para>The post-connection ringback tone codes for the caller. The value must contain codes for two scenarios, specified in the order of &quot;A as callee, B as callee&quot; and separated by commas.</para>
            /// <remarks>
            /// <para>&quot;1,2&quot; indicates that the ringback tone code for the caller when A is the callee is 1, and the code for the caller when B is the callee is 2.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("TAnucodeConnect")]
            [Validation(Required=false)]
            public string TAnucodeConnect { get; set; }

            /// <summary>
            /// <para>The A phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155****1111</para>
            /// </summary>
            [NameInMap("TelA")]
            [Validation(Required=false)]
            public string TelA { get; set; }

            /// <summary>
            /// <para>The N phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155****2222</para>
            /// </summary>
            [NameInMap("TelB")]
            [Validation(Required=false)]
            public string TelB { get; set; }

            /// <summary>
            /// <para>The privacy number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571******23</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

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
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8B9C3ED-D9BD-5E27-9588-6D84D3070160</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
