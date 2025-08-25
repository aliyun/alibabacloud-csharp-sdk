// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceAdvanceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("Enhance")]
        [Validation(Required=false)]
        public bool? Enhance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/ref/ref.jpg">https://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/ref/ref.jpg</a></para>
        /// </summary>
        [NameInMap("FaceImageURL")]
        [Validation(Required=false)]
        public Stream FaceImageURLObject { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeVideoModelFaceAdvanceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeVideoModelFaceAdvanceRequestMergeInfos : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("TemplateFaceID")]
            [Validation(Required=false)]
            public string TemplateFaceID { get; set; }

            [NameInMap("TemplateFaceURL")]
            [Validation(Required=false)]
            public string TemplateFaceURL { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3bf2418c-7adf-4002-a9d6-2f7cf1889c0d</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
