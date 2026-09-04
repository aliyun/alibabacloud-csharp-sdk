// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressStage : TeaModel {
        /// <summary>
        /// <para>阶段耗时（秒，保留 3 位小数）；一个 step 常整体落在同一秒内，故不取整</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.483</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>阶段结束时间（unix 秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>阶段标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>traj</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>阶段中文名</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成轨迹</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>匹配该阶段的日志标记文案</para>
        /// 
        /// <b>Example:</b>
        /// <para>start/end generation</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>是否为可选阶段；可选阶段未出现时状态记为 skipped</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Optional")]
        [Validation(Required=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// <para>阶段开始时间（unix 秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>done / running / waiting / pending / skipped</para>
        /// 
        /// <b>Example:</b>
        /// <para>done</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
