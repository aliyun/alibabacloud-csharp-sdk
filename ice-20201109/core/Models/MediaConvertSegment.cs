// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertSegment : TeaModel {
        /// <summary>
        /// <para>The length of the segment.</para>
        /// <list type="bullet">
        /// <item><description>Unit: seconds.</description></item>
        /// <item><description>Valid values: [1,60].</description></item>
        /// <item><description>Default value: 10. A value of 10 will create segments at the 10s, 20s, 30s, and 40s marks of the video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The points in time at which the video is forcibly segmented. Separate multiple points with commas (,). You can specify up to 10 points.</para>
        /// <list type="bullet">
        /// <item><description>Format: {Point in time},{Point in time},{Point in time}.</description></item>
        /// <item><description>Type: decimal. This parameter supports up to three decimal places.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// <item><description>Example: 1,2,4,6,10,14,18, which specifies that the video is forcibly segmented at the 1st, 2nd, 4th, 6th, 10th, 14th, and 18th seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ForceSegTime")]
        [Validation(Required=false)]
        public string ForceSegTime { get; set; }

    }

}
