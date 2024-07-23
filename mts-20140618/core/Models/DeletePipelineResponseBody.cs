// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class DeletePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the MPS queue that is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1ce4d3efcb549419193f50f1fcd****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>338CA33A-AE83-5DF4-B6F2-C6D3ED8143F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
