// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ExecuteAgentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For more information, see the following detailed description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Server-Sent Events (SSE) responses. Set to true to enable SSE responses. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
