// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListMetaEntitiesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListMetaEntitiesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>A list of metadata entities.</para>
            /// </summary>
            [NameInMap("MetaEntities")]
            [Validation(Required=false)]
            public List<MetaEntity> MetaEntities { get; set; }

            /// <summary>
            /// <para>The token used to retrieve the next page of results. If this parameter is empty, no more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6NmTbhyvglcoMCJsiEdngaTov15YaMyduvjIHYeTOIcEeXqCevM1qffZkwCkUTUYc=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADFASDFASDFA-ADFASDF-ASDFADSDF-AFFADS</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
