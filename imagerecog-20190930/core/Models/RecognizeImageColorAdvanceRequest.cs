// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeImageColorAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ColorCount")]
        [Validation(Required=false)]
        public int? ColorCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imagerecog/RecognizeImageColor/RecognizeImageColor1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imagerecog/RecognizeImageColor/RecognizeImageColor1.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
