// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsight : TeaModel {
        /// <summary>
        /// <para>Video summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>视频中展示了两个不同场景：一个是静止的白色盘子、黑色瓶子和透明玻璃杯，另一个是手拿着标有“YEZOLU”的洗发水瓶在浴室中缓慢上移。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The description of the video file.</para>
        /// <remarks>
        /// <para> Not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>无。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
