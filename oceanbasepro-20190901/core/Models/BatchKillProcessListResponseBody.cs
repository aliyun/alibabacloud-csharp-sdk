// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class BatchKillProcessListResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of the return result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchKillProcessListResponseBodyData> Data { get; set; }
        public class BatchKillProcessListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the calling is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
