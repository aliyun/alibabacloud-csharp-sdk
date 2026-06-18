// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateMemoryNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The memory node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68de06c95368463a8be4a84efcxxxxxx</para>
        /// </summary>
        [NameInMap("memoryNodeId")]
        [Validation(Required=false)]
        public string MemoryNodeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C56C7AF-xxxx-19CE-B018-E05E1EDCF4C5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
