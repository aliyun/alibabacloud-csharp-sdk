// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWorkwearShrinkRequest : TeaModel {
        [NameInMap("Clothes")]
        [Validation(Required=false)]
        public string ClothesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/tiyan/xxxx.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/zhangchaorun/tiyan/xxxx.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

    }

}
