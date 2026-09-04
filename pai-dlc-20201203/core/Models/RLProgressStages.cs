// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressStages : TeaModel {
        /// <summary>
        /// <para>当前所处阶段的下标</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("CurrentIndex")]
        [Validation(Required=false)]
        public int? CurrentIndex { get; set; }

        /// <summary>
        /// <para>disagg / colocate / 空串</para>
        /// 
        /// <b>Example:</b>
        /// <para>colocate</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>阶段列表，按流水线顺序</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;generation&quot;,&quot;Label&quot;:&quot;生成&quot;,&quot;Marker&quot;:&quot;start/end generation&quot;,&quot;Optional&quot;:false,&quot;Status&quot;:&quot;done&quot;,&quot;StartTime&quot;:1787474487,&quot;EndTime&quot;:1787474487,&quot;Duration&quot;:0.483}]</para>
        /// </summary>
        [NameInMap("Stages")]
        [Validation(Required=false)]
        public List<RLProgressStage> Stages { get; set; }

        /// <summary>
        /// <para>本 step 的阶段流水线是否已走完</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StepDone")]
        [Validation(Required=false)]
        public bool? StepDone { get; set; }

    }

}
