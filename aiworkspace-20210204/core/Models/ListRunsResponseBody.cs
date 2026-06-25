// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging token. For the first query, leave this parameter empty. The token for the next page is returned in the response. If the returned token is 0, all results have been returned. You can obtain the token for the next page from the <b>NextPageToken</b> field in the response.</para>
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
        /// <para>The total number of entries that meet the filter criteria. This parameter is optional and may not be returned.</para>
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
