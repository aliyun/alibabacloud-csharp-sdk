// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxnBindFixedLineResponseBody : TeaModel {
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
        /// <para>绑定对象</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAxnBindFixedLineResponseBodyData> Data { get; set; }
        public class QueryAxnBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>接通前放音啊编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002,10003</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>被叫侧放音编码</para>
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
            /// <para>010</para>
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
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public QueryAxnBindFixedLineResponseBodyDataExtra Extra { get; set; }
            public class QueryAxnBindFixedLineResponseBodyDataExtra : TeaModel {
                /// <summary>
                /// <para>A通过X呼叫，即A主叫X，仅下列值有效。默认是0。 0：不能外呼 1：接续最近的N号码 2：回拨固定号码：telB</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>录音控制，仅下列值有效。默认是0（不开通录音功能）。 0：不录音 1：录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Callrecording")]
                [Validation(Required=false)]
                public string Callrecording { get; set; }

            }

            /// <summary>
            /// <para>接入商自有字段，最大100字符长度</para>
            /// 
            /// <b>Example:</b>
            /// <para>12444</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>绑定id</para>
            /// 
            /// <b>Example:</b>
            /// <para>GHX0534X202504221531579290029-2-1-aliaxn</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>格式为yyyyMMddHHmmss。时间采用北京时间，24小时制。</para>
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
            /// <para>N号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>15500002222</para>
            /// </summary>
            [NameInMap("TelB")]
            [Validation(Required=false)]
            public string TelB { get; set; }

            /// <summary>
            /// <para>隐私号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>057112345678</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

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
        /// <para>E8B9C3ED-D9BD-5E27-9588-6D84D3070160</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
