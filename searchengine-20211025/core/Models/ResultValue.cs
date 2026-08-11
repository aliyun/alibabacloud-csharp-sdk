// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ResultValue : TeaModel {
        /// <summary>
        /// <para>Specifies whether to pause deployments to all destinations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseAll")]
        [Validation(Required=false)]
        public bool? PauseAll { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause deployments of new full indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndex")]
        [Validation(Required=false)]
        public bool? PauseIndex { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause deployments of incremental batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndexBatch")]
        [Validation(Required=false)]
        public bool? PauseIndexBatch { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause configuration deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseBiz")]
        [Validation(Required=false)]
        public bool? PauseBiz { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause real-time incremental updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseRuntime")]
        [Validation(Required=false)]
        public bool? PauseRuntime { get; set; }

    }

}
