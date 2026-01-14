// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class RetrieveResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public RetrieveResponseBodyData Data { get; set; }
        public class RetrieveResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>76cd1691-daf6-4113-8444-4998a25a5323</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public List<ChunkItem> Results { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
