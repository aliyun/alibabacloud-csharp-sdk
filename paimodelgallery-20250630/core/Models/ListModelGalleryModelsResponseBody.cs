// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class ListModelGalleryModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;SupportResponseSchema\&quot;: False, \&quot;ToolCall\&quot;: False, \&quot;ModelType\&quot;: \&quot;LLM\&quot;, \&quot;SupportReasoning\&quot;: False, \&quot;Model\&quot;: \&quot;ds1\&quot;, \&quot;SupportVision\&quot;: False, \&quot;MaxModelLength\&quot;: 4096}]</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public ModelGalleryModel Models { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6B54325-C98C-5937-87A3-2F96C07652EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
