// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The image details.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba cloud linux 3 full for H800</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190951671671438639388</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_7.9_x86_64_FULL_20221110</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.9</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALinux3</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40741292480fc6d778138adcf8c</para>
            /// </summary>
            [NameInMap("ReleaseFileMd5")]
            [Validation(Required=false)]
            public string ReleaseFileMd5 { get; set; }

            /// <summary>
            /// <para>The image size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.8G</para>
            /// </summary>
            [NameInMap("ReleaseFileSize")]
            [Validation(Required=false)]
            public string ReleaseFileSize { get; set; }

            /// <summary>
            /// <para>The image type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FC4A1C7-421C-5EAB-9361-4C0338EFA287</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
