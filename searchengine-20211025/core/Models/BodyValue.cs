// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class BodyValue : TeaModel {
        /// <summary>
        /// <para>Pauses all deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseAll")]
        [Validation(Required=false)]
        public bool? PauseAll { get; set; }

        /// <summary>
        /// <para>Pauses the deployment of new full index versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndex")]
        [Validation(Required=false)]
        public bool? PauseIndex { get; set; }

        /// <summary>
        /// <para>Pauses the deployment of incremental batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseIndexBatch")]
        [Validation(Required=false)]
        public bool? PauseIndexBatch { get; set; }

        /// <summary>
        /// <para>Pauses configuration deployments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseBiz")]
        [Validation(Required=false)]
        public bool? PauseBiz { get; set; }

        /// <summary>
        /// <para>Pauses real-time incremental updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("pauseRuntime")]
        [Validation(Required=false)]
        public bool? PauseRuntime { get; set; }

    }

}
