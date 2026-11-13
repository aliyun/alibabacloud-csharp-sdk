// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ClusterStage : TeaModel {
        /// <summary>
        /// <para>The ordinal number of the current execution stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CurrentStage")]
        [Validation(Required=false)]
        public int? CurrentStage { get; set; }

        /// <summary>
        /// <para>The execution information of the current stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating resources</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The execution status of the current stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of execution stages and their weights.</para>
        /// </summary>
        [NameInMap("TotalStageWithWeight")]
        [Validation(Required=false)]
        public List<StageWithWeight> TotalStageWithWeight { get; set; }

    }

}
