// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateMemoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The long-term memory ID.</para>
        /// <remarks>
        /// <para>Store this value properly. It is required for all subsequent API operations related to this long-term memory.
        /// .</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6bff4f317a14442fbc9f73d29dbxxxx</para>
        /// </summary>
        [NameInMap("memoryId")]
        [Validation(Required=false)]
        public string MemoryId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A--2446A84821CA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
