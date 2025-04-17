// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryLocationDateClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of spatiotemporal clusters.</para>
        /// </summary>
        [NameInMap("LocationDateClusters")]
        [Validation(Required=false)]
        public List<LocationDateCluster> LocationDateClusters { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzQNjmY2MzYxNhNjk2ZNjEu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7055FCF7-4D7B-098E-BD4D-DD2932B0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
