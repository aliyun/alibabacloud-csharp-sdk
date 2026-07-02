// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class PPTDetails : TeaModel {
        /// <summary>
        /// <para>The image path of the PPT frame capture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ppts/video_snapshots_0.jpg&quot;</para>
        /// </summary>
        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// <para>The index of the PPT frame capture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PPTShotIndex")]
        [Validation(Required=false)]
        public long? PPTShotIndex { get; set; }

        /// <summary>
        /// <para>The time in the video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
