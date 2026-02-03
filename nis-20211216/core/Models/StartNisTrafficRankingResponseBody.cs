// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class StartNisTrafficRankingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>task-6462a7b4c4a54b****</para>
        /// </summary>
        [NameInMap("NisTrafficRankingId")]
        [Validation(Required=false)]
        public string NisTrafficRankingId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
