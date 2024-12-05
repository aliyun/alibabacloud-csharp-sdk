// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ResultValue : TeaModel {
        /// <summary>
        /// <para>Indicates whether all pushes are suspended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseAll")]
        [Validation(Required=false)]
        public bool? PauseAll { get; set; }

        /// <summary>
        /// <para>Indicates whether the push is suspended for the new full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndex")]
        [Validation(Required=false)]
        public bool? PauseIndex { get; set; }

        /// <summary>
        /// <para>Indicates whether the push is suspended for the incremental indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndexBatch")]
        [Validation(Required=false)]
        public bool? PauseIndexBatch { get; set; }

        /// <summary>
        /// <para>Indicates whether the push is suspended for the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseBiz")]
        [Validation(Required=false)]
        public bool? PauseBiz { get; set; }

        /// <summary>
        /// <para>Indicates whether the push is suspended for the real-time incremental indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseRuntime")]
        [Validation(Required=false)]
        public bool? PauseRuntime { get; set; }

    }

}
