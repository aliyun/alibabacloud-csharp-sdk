// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SearchImageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliuid:1998006665794443 assumeRole not exist,serviceName:realtimelogpush.dcdnservices.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ImageResponse")]
        [Validation(Required=false)]
        public SearchImageResponseBodyImageResponse ImageResponse { get; set; }
        public class SearchImageResponseBodyImageResponse : TeaModel {
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<SearchImageResponseBodyImageResponseImageList> ImageList { get; set; }
            public class SearchImageResponseBodyImageResponseImageList : TeaModel {
                [NameInMap("DescriptiveTones")]
                [Validation(Required=false)]
                public string DescriptiveTones { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                [NameInMap("ImageRatio")]
                [Validation(Required=false)]
                public string ImageRatio { get; set; }

                /// <summary>
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

                [NameInMap("QuantitativePalette")]
                [Validation(Required=false)]
                public string QuantitativePalette { get; set; }

                [NameInMap("TagsFromImage")]
                [Validation(Required=false)]
                public string TagsFromImage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/RollTicket_01.jpeg">https://other-general-huadong1.oss-cn-hangzhou.aliyuncs.com/uploadWidget/RollTicket_01.jpeg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>154</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
