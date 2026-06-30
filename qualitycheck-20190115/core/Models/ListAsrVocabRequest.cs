// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListAsrVocabRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For more information, see the details below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pageSize&quot;:1}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
