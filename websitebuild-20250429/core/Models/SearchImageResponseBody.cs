// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SearchImageResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. The ErrorCode field is not returned if the request succeeded. If the request failed, the ErrorCode field is returned. For more information, see the error code list in this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid:1998006665794443 assumeRole not exist,serviceName:realtimelogpush.dcdnservices.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Image search Result</para>
        /// </summary>
        [NameInMap("ImageResponse")]
        [Validation(Required=false)]
        public SearchImageResponseBodyImageResponse ImageResponse { get; set; }
        public class SearchImageResponseBodyImageResponse : TeaModel {
            /// <summary>
            /// <para>Image List</para>
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<SearchImageResponseBodyImageResponseImageList> ImageList { get; set; }
            public class SearchImageResponseBodyImageResponseImageList : TeaModel {
                /// <summary>
                /// <para>Descriptive hues detected in the Image</para>
                /// 
                /// <b>Example:</b>
                /// <para>冷色调 蓝色</para>
                /// </summary>
                [NameInMap("DescriptiveTones")]
                [Validation(Required=false)]
                public string DescriptiveTones { get; set; }

                /// <summary>
                /// <para>Image height</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>Image categorization. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description>normal: Illustrations or article images.  </description></item>
                /// <item><description>banner: Background images or image carousels.  </description></item>
                /// <item><description>goods: Product or service images.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// <para>Aspect ratio</para>
                /// 
                /// <b>Example:</b>
                /// <para>16:9</para>
                /// </summary>
                [NameInMap("ImageRatio")]
                [Validation(Required=false)]
                public string ImageRatio { get; set; }

                /// <summary>
                /// <para>Image UUID</para>
                /// 
                /// <b>Example:</b>
                /// <para>70687446-821c-4ebd-9be6-b57dc0a3500a</para>
                /// </summary>
                [NameInMap("ImageUuid")]
                [Validation(Required=false)]
                public string ImageUuid { get; set; }

                /// <summary>
                /// <para>oss key</para>
                /// 
                /// <b>Example:</b>
                /// <para>1ad5/c728/cb40/2410/e01d/b24c/9acd/7d51/1ad5c728cb402410e01db24c9acd7d51</para>
                /// </summary>
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                /// <summary>
                /// <para>Quantized color palette (HEX, LAB) extracted by the algorithm</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;hex&quot;: &quot;#3a3f58&quot;, &quot;rgb&quot;: {&quot;r&quot;: 58, &quot;g&quot;: 63, &quot;b&quot;: 88 }, &quot;lab&quot;: {&quot;l&quot;: 27.81, &quot;a&quot;: 2.95, &quot;b&quot;: -16.52 }, &quot;percentage&quot;: 0.4521 }, {&quot;hex&quot;: &quot;#c8a16a&quot;, &quot;rgb&quot;: {&quot;r&quot;: 200, &quot;g&quot;: 161, &quot;b&quot;: 106 }, &quot;lab&quot;: {&quot;l&quot;: 69.35, &quot;a&quot;: 11.23, &quot;b&quot;: 35.18 }, &quot;percentage&quot;: 0.2355 }, {&quot;hex&quot;: &quot;#f1e8da&quot;, &quot;rgb&quot;: {&quot;r&quot;: 241, &quot;g&quot;: 232, &quot;b&quot;: 218 }, &quot;lab&quot;: {&quot;l&quot;: 93.17, &quot;a&quot;: 1.76, &quot;b&quot;: 7.91 }, &quot;percentage&quot;: 0.1873 } ]</para>
                /// </summary>
                [NameInMap("QuantitativePalette")]
                [Validation(Required=false)]
                public string QuantitativePalette { get; set; }

                /// <summary>
                /// <para>Image tags</para>
                /// 
                /// <b>Example:</b>
                /// <para>日出、奔跑</para>
                /// </summary>
                [NameInMap("TagsFromImage")]
                [Validation(Required=false)]
                public string TagsFromImage { get; set; }

                /// <summary>
                /// <para>Temporary access URL of the image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/RollTicket_01.jpeg">https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/RollTicket_01.jpeg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Image width</para>
                /// 
                /// <b>Example:</b>
                /// <para>154</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>Number of results per query.</para>
            /// <para>Value range: 10–100. Default Value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>Token indicating the start of the next query. It is empty when there is no next query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2c6b65b6f9d625d4e2514a628bde8eb2e0b5e8707e68181f</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
