// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token. Pass an empty value for the first page query. The query result returns the token for the next page. A token value of 0 indicates that all data has been retrieved. You can obtain the token for the next page from the NextPageToken field in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The list of runs.</para>
        /// </summary>
        [NameInMap("Runs")]
        [Validation(Required=false)]
        public List<Run> Runs { get; set; }

        /// <summary>
        /// <para>The total number of records that match the request conditions. This is an optional parameter and may not be returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF6D849-*****-7E7030F0CE53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
