// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CFB2DED-7D9B-4C42-B4AA-CFF4991DFFF4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned information about objects.</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ReturnValue { get; set; }

    }

}
