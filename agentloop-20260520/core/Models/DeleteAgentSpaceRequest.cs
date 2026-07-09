// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteAgentSpaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the associated Hybrid Cloud Monitoring workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deleteCmsWorkspace")]
        [Validation(Required=false)]
        public bool? DeleteCmsWorkspace { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the associated MSE namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deleteMseNamespace")]
        [Validation(Required=false)]
        public bool? DeleteMseNamespace { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the associated SLS project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deleteSlsProject")]
        [Validation(Required=false)]
        public bool? DeleteSlsProject { get; set; }

    }

}
