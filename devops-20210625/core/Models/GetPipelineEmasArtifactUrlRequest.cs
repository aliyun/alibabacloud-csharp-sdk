// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineEmasArtifactUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("serviceConnectionId")]
        [Validation(Required=false)]
        public long? ServiceConnectionId { get; set; }

    }

}
