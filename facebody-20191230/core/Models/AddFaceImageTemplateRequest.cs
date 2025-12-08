// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddFaceImageTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/img_facefusion/template/sucai1.jpg">https://invi-label.oss-cn-shanghai.aliyuncs.com/label/temp/faceswap/img_facefusion/template/sucai1.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

    }

}
