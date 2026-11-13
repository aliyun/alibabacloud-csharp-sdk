// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RerunTaskInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The list of task instance IDs.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to rerun the task instance with the latest configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseLatestConfig")]
        [Validation(Required=false)]
        public bool? UseLatestConfig { get; set; }

    }

}
