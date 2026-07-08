// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListWarehouseResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of warehouse objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWarehouseResponseBodyData> Data { get; set; }
        public class ListWarehouseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The warehouse instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-wh-Q7ID6V</para>
            /// </summary>
            [NameInMap("WarehouseInstanceId")]
            [Validation(Required=false)]
            public string WarehouseInstanceId { get; set; }

            /// <summary>
            /// <para>The warehouse name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default_warehouse</para>
            /// </summary>
            [NameInMap("WarehouseName")]
            [Validation(Required=false)]
            public string WarehouseName { get; set; }

            /// <summary>
            /// <para>The warehouse type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcaCaCert</para>
            /// </summary>
            [NameInMap("WarehouseType")]
            [Validation(Required=false)]
            public string WarehouseType { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on each page. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is not returned, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5979d897-d69f-4fc9-87dd-f3bb73c40b80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the result set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
