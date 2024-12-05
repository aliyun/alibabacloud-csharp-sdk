// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexRecoverRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The time when the index version was published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-07 16:43:00</para>
        /// </summary>
        [NameInMap("finishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// <para>The ID of the full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1708674867</para>
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public string GenerationId { get; set; }

    }

}
