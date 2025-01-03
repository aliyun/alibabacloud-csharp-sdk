// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdatePipelineBaseInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("envId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;11,222,33&quot;</para>
        /// </summary>
        [NameInMap("tagList")]
        [Validation(Required=false)]
        public string TagList { get; set; }

    }

}
