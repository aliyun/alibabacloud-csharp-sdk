// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class EnhanceImageColorRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/EnhanceImageColor/EnhanceImageColor1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/EnhanceImageColor/EnhanceImageColor1.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogC</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

    }

}
