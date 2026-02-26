// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SceneElement : TeaModel {
        /// <summary>
        /// <para>The time points of frames that match the searched content within the element. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("FrameTimes")]
        [Validation(Required=false)]
        public List<long?> FrameTimes { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The time range of the element. The array length is fixed at 2. One is the start time and the other is the end time. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

        [NameInMap("VideoStreamIndex")]
        [Validation(Required=false)]
        public long? VideoStreamIndex { get; set; }

    }

}
