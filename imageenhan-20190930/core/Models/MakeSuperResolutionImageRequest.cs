// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class MakeSuperResolutionImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("OutputQuality")]
        [Validation(Required=false)]
        public long? OutputQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UpscaleFactor")]
        [Validation(Required=false)]
        public long? UpscaleFactor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/MakeSuperResolutionImage/MakeSuperResolutionImage5.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/MakeSuperResolutionImage/MakeSuperResolutionImage5.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
