// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorHDImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ColorCount")]
        [Validation(Required=false)]
        public int? ColorCount { get; set; }

        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ColorTemplate")]
        [Validation(Required=false)]
        public List<RecolorHDImageRequestColorTemplate> ColorTemplate { get; set; }
        public class RecolorHDImageRequestColorTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[3F6A6B,0A0A6F]</para>
            /// </summary>
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4</para>
        /// </summary>
        [NameInMap("Degree")]
        [Validation(Required=false)]
        public string Degree { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REF_PIC</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorHDImage/RecolorHDImage-REF_PIC6.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorHDImage/RecolorHDImage-REF_PIC6.jpg</a></para>
        /// </summary>
        [NameInMap("RefUrl")]
        [Validation(Required=false)]
        public string RefUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorHDImage/RecolorHDImage-auto1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RecolorHDImage/RecolorHDImage-auto1.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
