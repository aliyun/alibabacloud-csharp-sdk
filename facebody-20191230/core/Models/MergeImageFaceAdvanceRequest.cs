// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MergeImageFaceAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/MergeImageFace/MergeImageFace-1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/MergeImageFace/MergeImageFace-1.png</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeImageFaceAdvanceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeImageFaceAdvanceRequestMergeInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/ref/ref.jpg">http://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/ref/ref.jpg</a></para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048_0</para>
            /// </summary>
            [NameInMap("TemplateFaceID")]
            [Validation(Required=false)]
            public string TemplateFaceID { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
