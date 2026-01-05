// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTrademarkResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsTrademarkResponseBodyData> Data { get; set; }
        public class QuerySmsTrademarkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>申请人名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TrademarkApplicantName")]
            [Validation(Required=false)]
            public string TrademarkApplicantName { get; set; }

            /// <summary>
            /// <para>专用权生失效日期</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-01~2025-12-19</para>
            /// </summary>
            [NameInMap("TrademarkEffExpDate")]
            [Validation(Required=false)]
            public string TrademarkEffExpDate { get; set; }

            /// <summary>
            /// <para>商标材料id</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000*******</para>
            /// </summary>
            [NameInMap("TrademarkId")]
            [Validation(Required=false)]
            public long? TrademarkId { get; set; }

            /// <summary>
            /// <para>商标名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

            /// <summary>
            /// <para>商标截图Osskey（给签名传工单用）</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000*<b><b>802/afdebd46-</b></b>-46e4-899d-b4375826c898_mhk9oz0p_1762****31542.png</para>
            /// </summary>
            [NameInMap("TrademarkPic")]
            [Validation(Required=false)]
            public string TrademarkPic { get; set; }

            /// <summary>
            /// <para>商标截图url地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&OSSAccessKeyId=bypFN****73PsLI&Signature=BygI9X****h7%2FXmFIo****FB2c%3D">https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&amp;OSSAccessKeyId=bypFN****73PsLI&amp;Signature=BygI9X****h7%2FXmFIo****FB2c%3D</a></para>
            /// </summary>
            [NameInMap("TrademarkPicUrl")]
            [Validation(Required=false)]
            public string TrademarkPicUrl { get; set; }

            /// <summary>
            /// <para>商标注册号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TrademarkRegistrationNumber")]
            [Validation(Required=false)]
            public string TrademarkRegistrationNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>569E9DBD-23FF-1785-99AD-E4B23608C104</para>
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
