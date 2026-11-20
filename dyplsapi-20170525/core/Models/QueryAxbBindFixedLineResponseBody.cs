// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxbBindFixedLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The API request status code. Valid values:
        /// 0: Success. For other error codes, see <a href="https://help.aliyun.com/document_detail/59892.html">API error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The binding information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAxbBindFixedLineResponseBodyData Data { get; set; }
        public class QueryAxbBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ringback tone code played before the call is connected. The code must include codes for three scenarios. Specify the codes in the order of &quot;B-&gt;X, A-&gt;X, other numbers-&gt;X&quot;, separated by commas. </para>
            /// <remarks>
            /// <para>&quot;1,2,3&quot; indicates that the ringback tone code for B-&gt;X is 1, for A-&gt;X is 2, and for other numbers-&gt;X is 3.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>The ringback tone code played to the called party after the call is connected.</para>
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
            /// <item><description><para>0: Never expires.</para>
            /// </description></item>
            /// <item><description><para>Other values: When set to another value such as 60, the binding remains valid for 60 seconds after the X number is successfully assigned. After 60 seconds, the binding is automatically released.</para>
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
            public QueryAxbBindFixedLineResponseBodyDataExtra Extra { get; set; }
            public class QueryAxbBindFixedLineResponseBodyDataExtra : TeaModel {
                /// <summary>
                /// <para>The call recording control. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0 (default): Do not record.</para>
                /// </description></item>
                /// <item><description><para>1: Record.</para>
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
            /// <para>The ringback tone code played to the caller after the call is connected. The code must include codes for two scenarios. Specify the codes in the order of &quot;A as callee, B as callee&quot;, separated by commas.</para>
            /// <remarks>
            /// <para>&quot;1,2&quot; indicates that the ringback tone code played to the caller when A is the callee is 1, and when B is the callee is 2.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("TAnucodeConnect")]
            [Validation(Required=false)]
            public string TAnucodeConnect { get; set; }

            /// <summary>
            /// <para>The A number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155****1111</para>
            /// </summary>
            [NameInMap("TelA")]
            [Validation(Required=false)]
            public string TelA { get; set; }

            /// <summary>
            /// <para>The B number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155****2222</para>
            /// </summary>
            [NameInMap("TelB")]
            [Validation(Required=false)]
            public string TelB { get; set; }

            /// <summary>
            /// <para>The X number of the AXB landline privacy number. The X number is a privacy number that you have <a href="https://dyplsnext.console.aliyun.com/numberbuy">purchased</a> in the console.</para>
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
        /// <para>3179F199-C6C5-5963-85A6-21CBA2F47592</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failure.</para>
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
