// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressStages : TeaModel {
        /// <summary>
        /// <para>The index of the current stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("CurrentIndex")]
        [Validation(Required=false)]
        public int? CurrentIndex { get; set; }

        /// <summary>
        /// <para>The disagg, colocate, or empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>colocate</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The list of stages in pipeline order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;generation&quot;,&quot;Label&quot;:&quot;Generation&quot;,&quot;Marker&quot;:&quot;start/end generation&quot;,&quot;Optional&quot;:false,&quot;Status&quot;:&quot;done&quot;,&quot;StartTime&quot;:1787474487,&quot;EndTime&quot;:1787474487,&quot;Duration&quot;:0.483}]</para>
        /// </summary>
        [NameInMap("Stages")]
        [Validation(Required=false)]
        public List<RLProgressStage> Stages { get; set; }

        /// <summary>
        /// <para>Indicates whether the stage pipeline for this step is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StepDone")]
        [Validation(Required=false)]
        public bool? StepDone { get; set; }

    }

}
