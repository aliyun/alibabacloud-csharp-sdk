// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxbBindFixedLineResponseBody : TeaModel {
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
        /// <para>绑定信息</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAxbBindFixedLineResponseBodyData Data { get; set; }
        public class QueryAxbBindFixedLineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>接通前放音编码，放音编码必须包含3个场景的编码。按照“B-&gt;X,A-&gt;X,其他号码-&gt;X”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2,3”表示B-&gt;X放音编号为1，A-&gt;X放音编号为2， 其他号码-&gt;X放音编号为3</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001,10002,10003</para>
            /// </summary>
            [NameInMap("Anucode")]
            [Validation(Required=false)]
            public string Anucode { get; set; }

            /// <summary>
            /// <para>接通后被叫侧放音编码</para>
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
            /// <para>绑定过期时间</para>
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
            public QueryAxbBindFixedLineResponseBodyDataExtra Extra { get; set; }
            public class QueryAxbBindFixedLineResponseBodyDataExtra : TeaModel {
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
            /// <para>接入商自有字段，最大250字符长度</para>
            /// 
            /// <b>Example:</b>
            /// <para>19394</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>绑定id</para>
            /// 
            /// <b>Example:</b>
            /// <para>GHX0534X202504221531579290029-2-1-aliaxb</para>
            /// </summary>
            [NameInMap("Subid")]
            [Validation(Required=false)]
            public string Subid { get; set; }

            /// <summary>
            /// <para>绑定时间，格式为yyyyMMddHHmmss。时间采用北京时间，24小时制。</para>
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
            /// <para>示例值示例值</para>
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
            /// <para>B号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>15500002222</para>
            /// </summary>
            [NameInMap("TelB")]
            [Validation(Required=false)]
            public string TelB { get; set; }

            /// <summary>
            /// <para>小号号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>19700002222</para>
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
        /// <para>3179F199-C6C5-5963-85A6-21CBA2F47592</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>处理是否成功 true-成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
