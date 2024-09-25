// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFaceVerifyRequest : TeaModel {
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PV_FC</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("SourceCertifyId")]
        [Validation(Required=false)]
        public string SourceCertifyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceFaceContrastPicture")]
        [Validation(Required=false)]
        public string SourceFaceContrastPicture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("SourceFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string SourceFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("SourceOssBucketName")]
        [Validation(Required=false)]
        public string SourceOssBucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("SourceOssObjectName")]
        [Validation(Required=false)]
        public string SourceOssObjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("TargetCertifyId")]
        [Validation(Required=false)]
        public string TargetCertifyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("TargetFaceContrastPicture")]
        [Validation(Required=false)]
        public string TargetFaceContrastPicture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("TargetFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string TargetFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("TargetOssBucketName")]
        [Validation(Required=false)]
        public string TargetOssBucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("TargetOssObjectName")]
        [Validation(Required=false)]
        public string TargetOssObjectName { get; set; }

    }

}
