// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListJobSanityCheckResultsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1AC9xxx-3xxx-5xxx2-xxxx-FA5</para>
        /// </summary>
        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("SanityCheckResults")]
        [Validation(Required=false)]
        public List<List<SanityCheckResultItem>> SanityCheckResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
