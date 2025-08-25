// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextAndImageAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>center_crop</para>
        /// </summary>
        [NameInMap("AspectRatioMode")]
        [Validation(Required=false)]
        public string AspectRatioMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/yxrtest/%E6%96%87%E7%94%9F%E5%9B%BE/%E7%9D%A1%E8%8E%B2.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/yxrtest/%E6%96%87%E7%94%9F%E5%9B%BE/%E7%9D%A1%E8%8E%B2.jpg</a>&quot;</para>
        /// </summary>
        [NameInMap("RefImageUrl")]
        [Validation(Required=false)]
        public Stream RefImageUrlObject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024*1024</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("Similarity")]
        [Validation(Required=false)]
        public float? Similarity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
