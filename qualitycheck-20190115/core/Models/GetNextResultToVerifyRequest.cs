// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetNextResultToVerifyRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;pageNumber&quot;:1,&quot;pageSize&quot;:1,&quot;taskId&quot;:&quot;593A04C0-E6E9-4CDC-8C9*****&quot;,&quot;original&quot;:1}&quot;</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
