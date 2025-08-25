// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RemoveImageSubtitlesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.25</para>
        /// </summary>
        [NameInMap("BH")]
        [Validation(Required=false)]
        public float? BH { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BW")]
        [Validation(Required=false)]
        public float? BW { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BX")]
        [Validation(Required=false)]
        public float? BX { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.75</para>
        /// </summary>
        [NameInMap("BY")]
        [Validation(Required=false)]
        public float? BY { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RemoveImageSubtitles/RemoveImageSubtitles1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/imageenhan/RemoveImageSubtitles/RemoveImageSubtitles1.jpg</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

    }

}
