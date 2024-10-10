// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ConfirmPipelineBatchRequest : TeaModel {
        /// <summary>
        /// <para>true</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Confirm")]
        [Validation(Required=false)]
        public bool? Confirm { get; set; }

        /// <summary>
        /// <para>e2e-vds-feh-\<em>\</em>\*</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2e-vds-feh-***</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
