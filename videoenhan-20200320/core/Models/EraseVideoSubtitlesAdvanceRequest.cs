// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EraseVideoSubtitlesAdvanceRequest : TeaModel {
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
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoenhan/EraseVideoSubtitles/EraseVideoSubtitles1.mp4">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoenhan/EraseVideoSubtitles/EraseVideoSubtitles1.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
