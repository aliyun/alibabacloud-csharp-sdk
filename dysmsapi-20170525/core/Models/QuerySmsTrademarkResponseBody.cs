// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTrademarkResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para><c>OK</c> indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A list of trademark details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySmsTrademarkResponseBodyData> Data { get; set; }
        public class QuerySmsTrademarkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The applicant name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("TrademarkApplicantName")]
            [Validation(Required=false)]
            public string TrademarkApplicantName { get; set; }

            /// <summary>
            /// <para>The validity period of the trademark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-01~2025-12-19</para>
            /// </summary>
            [NameInMap("TrademarkEffExpDate")]
            [Validation(Required=false)]
            public string TrademarkEffExpDate { get; set; }

            /// <summary>
            /// <para>The trademark ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000*******</para>
            /// </summary>
            [NameInMap("TrademarkId")]
            [Validation(Required=false)]
            public long? TrademarkId { get; set; }

            /// <summary>
            /// <para>The name of the trademark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例商标</para>
            /// </summary>
            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) file key for the trademark image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000*<b><b>802/afdebd46-</b></b>-46e4-899d-b4375826c898_mhk9oz0p_1762****31542.png</para>
            /// </summary>
            [NameInMap("TrademarkPic")]
            [Validation(Required=false)]
            public string TrademarkPic { get; set; }

            /// <summary>
            /// <para>The URL of the trademark screenshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&OSSAccessKeyId=bypFN****73PsLI&Signature=BygI9X****h7%2FXmFIo****FB2c%3D">https://alicom-fc-media.oss-cn-zhangjiakou.aliyuncs.com/100000****50802/afde****-496d-46e4-899d-b43758****8_mhk9oz0p_176224****542.png?Expires=1762****6&amp;OSSAccessKeyId=bypFN****73PsLI&amp;Signature=BygI9X****h7%2FXmFIo****FB2c%3D</a></para>
            /// </summary>
            [NameInMap("TrademarkPicUrl")]
            [Validation(Required=false)]
            public string TrademarkPicUrl { get; set; }

            /// <summary>
            /// <para>The trademark registration number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TrademarkRegistrationNumber")]
            [Validation(Required=false)]
            public string TrademarkRegistrationNumber { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>569E9DBD-23FF-1785-99AD-E4B23608C104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request fails.</para>
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
