// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ImageBlindCharacterWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>encode_text</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/xxxxx.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/xxxxx.jpg</a></para>
        /// </summary>
        [NameInMap("OriginImageURL")]
        [Validation(Required=false)]
        public string OriginImageURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("OutputFileType")]
        [Validation(Required=false)]
        public string OutputFileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("QualityFactor")]
        [Validation(Required=false)]
        public int? QualityFactor { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://viapi-doc.oss-cn-shanghai.aliyuncs.com/imageenhan/xxxxx.jpg">https://viapi-doc.oss-cn-shanghai.aliyuncs.com/imageenhan/xxxxx.jpg</a></para>
        /// </summary>
        [NameInMap("WatermarkImageURL")]
        [Validation(Required=false)]
        public string WatermarkImageURL { get; set; }

    }

}
