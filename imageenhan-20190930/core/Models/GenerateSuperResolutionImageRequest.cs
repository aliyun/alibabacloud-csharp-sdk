// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateSuperResolutionImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/xxx/1025.jpg">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/xxx/1025.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("OutputQuality")]
        [Validation(Required=false)]
        public int? OutputQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
