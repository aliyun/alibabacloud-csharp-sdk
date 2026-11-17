// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySourceUsageSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of retrieval recalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("retrievalCount")]
        [Validation(Required=false)]
        public long? RetrievalCount { get; set; }

        /// <summary>
        /// <para>The deduplicated count of sources that have retrieval events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("retrievedSourceCount")]
        [Validation(Required=false)]
        public long? RetrievedSourceCount { get; set; }

        /// <summary>
        /// <para>The number of rows in the source data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("sourceCount")]
        [Validation(Required=false)]
        public long? SourceCount { get; set; }

        /// <summary>
        /// <para>The number of times the source has been used in agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("usageCount")]
        [Validation(Required=false)]
        public long? UsageCount { get; set; }

        /// <summary>
        /// <para>The deduplicated count of sources that have usage events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("usedSourceCount")]
        [Validation(Required=false)]
        public long? UsedSourceCount { get; set; }

    }

}
