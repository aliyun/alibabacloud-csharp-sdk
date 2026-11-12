// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RestartAIDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. Usage notes: Add a description of the supported cluster types to the DBClusterId parameter description and clarify the meaning of the example value prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
