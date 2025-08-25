// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ColorCount")]
        [Validation(Required=false)]
        public int? ColorCount { get; set; }

        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ColorTemplate")]
        [Validation(Required=false)]
        public List<RecolorImageRequestColorTemplate> ColorTemplate { get; set; }
        public class RecolorImageRequestColorTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>056A6B</para>
            /// </summary>
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEMPLATE</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorImage/RecolorImage-REF_PIC7.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorImage/RecolorImage-REF_PIC7.jpg</a></para>
        /// </summary>
        [NameInMap("RefUrl")]
        [Validation(Required=false)]
        public string RefUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorImage/RecolorImage-REF_PIC1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorImage/RecolorImage-REF_PIC1.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
