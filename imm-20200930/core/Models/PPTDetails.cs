// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class PPTDetails : TeaModel {
        /// <summary>
        /// <para>The URL of the captured slide image, which is stored in an Object Storage Service (OSS) bucket.</para>
        /// </summary>
        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// <para>The zero-based index of the slide in the sequence of detected slides.</para>
        /// </summary>
        [NameInMap("PPTShotIndex")]
        [Validation(Required=false)]
        public long? PPTShotIndex { get; set; }

        /// <summary>
        /// <para>The start time of the slide, in milliseconds, from the beginning of the video.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
