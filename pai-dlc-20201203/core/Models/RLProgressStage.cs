// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressStage : TeaModel {
        /// <summary>
        /// <para>The duration of the stage in seconds, with three decimal places. A step often falls entirely within the same second, so the value is not rounded to an integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.483</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The end time of the stage in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The stage identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traj</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The Chinese name of the stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generate trace</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The log marker text used to match the stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start/end generation</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>Specifies whether the stage is optional. If an optional stage does not occur, its status is recorded as skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Optional")]
        [Validation(Required=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// <para>The start time of the stage in UNIX seconds.</para>
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
