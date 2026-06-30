// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateAsrVocabRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Full JSON string. See the details below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;热词名称&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
