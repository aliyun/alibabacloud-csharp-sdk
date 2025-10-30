// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxnExtensionBindFixedLineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>响应码</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>查询绑定对象集合，具体对象字段见绑定请求</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAxnExtensionBindFixedLineResponseBodyData> Data { get; set; }
        public class QueryAxnExtensionBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>放音编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002,10003</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>被叫侧放音</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002</para>
            /// </summary>
            [NameInMap("Anucodecalled")]
            [Validation(Required=false)]
            public string Anucodecalled { get; set; }

            /// <summary>
            /// <para>隐私号码区号</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Areacode")]
            [Validation(Required=false)]
            public string Areacode { get; set; }

            /// <summary>
            /// <para>过期时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>额外字段</para>
            /// </summary>
            [NameInMap("Extraaxx")]
            [Validation(Required=false)]
            public QueryAxnExtensionBindFixedLineResponseBodyDataExtraaxx Extraaxx { get; set; }
            public class QueryAxnExtensionBindFixedLineResponseBodyDataExtraaxx : TeaModel {
                /// <summary>
                /// <para>回拨控制</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>录音控制</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Callrecording")]
                [Validation(Required=false)]
                public string Callrecording { get; set; }

            }

            /// <summary>
            /// <para>接入商自有字段，最大250字符长度</para>
            /// 
            /// <b>Example:</b>
            /// <para>12444</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>绑定ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>可参考绑定响应</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>绑定时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250421141723</para>
            /// </summary>
            [NameInMap("Subts")]
            [Validation(Required=false)]
            public string Subts { get; set; }

            /// <summary>
            /// <para>接通后主叫侧放音编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002</para>
            /// </summary>
            [NameInMap("TAnucodeConnect")]
            [Validation(Required=false)]
            public string TAnucodeConnect { get; set; }

            /// <summary>
            /// <para>A号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>15500001111</para>
            /// </summary>
            [NameInMap("TelA")]
            [Validation(Required=false)]
            public string TelA { get; set; }

            /// <summary>
            /// <para>小号号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>19700002222</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

            /// <summary>
            /// <para>分机号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009</para>
            /// </summary>
            [NameInMap("TelXext")]
            [Validation(Required=false)]
            public string TelXext { get; set; }

        }

        /// <summary>
        /// <para>描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>74EFA0E8-CFCA-54D9-BFE5-904F9FA88DBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
