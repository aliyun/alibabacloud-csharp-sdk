// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SceneElement : TeaModel {
        /// <summary>
        /// <para>The timestamps of the frames within the current video element that match the search content. The unit is milliseconds.</para>
        /// </summary>
        [NameInMap("FrameTimes")]
        [Validation(Required=false)]
        public List<long?> FrameTimes { get; set; }

        /// <summary>
        /// <para>The label information.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The time range of the video element. The array has a fixed length of 2. The two values represent the start time and end time in milliseconds.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

        /// <summary>
        /// <para>The index of the video stream to which the current video scene element belongs. This corresponds to the index in the <a href="https://help.aliyun.com/zh/imm/developer-reference/api-imm-2020-09-30-detectmediameta?spm=a2c4g.11186623.0.0.463e600fIDdM8r#api-detail-40">VideoStreams</a> array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VideoStreamIndex")]
        [Validation(Required=false)]
        public long? VideoStreamIndex { get; set; }

    }

}
