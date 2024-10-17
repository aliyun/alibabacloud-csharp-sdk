// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingIndexFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL of the index file.</para>
        /// </summary>
        [NameInMap("IndexFile")]
        [Validation(Required=false)]
        public string IndexFile { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E84BE44-58A7-<b><b>-</b></b>-FBEBEA16EF94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
