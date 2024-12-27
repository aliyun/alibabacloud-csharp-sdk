// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QuerySimilarImageClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token. If the total number of clusters is greater than the value of MaxResults, this token can be used to retrieve the next page. This parameter has a value only if not all the clusters that meet the condition are returned.</para>
        /// <para>Pass this value as the value of NextToken in the next query to return the subsequent clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KClVwZGF0ZVRpbWUQARgBIs8ECgkAAJLUwUCAQ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of similar image clusters.</para>
        /// </summary>
        [NameInMap("SimilarImageClusters")]
        [Validation(Required=false)]
        public List<SimilarImageCluster> SimilarImageClusters { get; set; }

    }

}
