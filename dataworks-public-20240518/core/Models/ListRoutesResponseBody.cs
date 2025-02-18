// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListRoutesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListRoutesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of network resource routing information obtained.</para>
            /// </summary>
            [NameInMap("RouteList")]
            [Validation(Required=false)]
            public List<ListRoutesResponseBodyPagingInfoRouteList> RouteList { get; set; }
            public class ListRoutesResponseBodyPagingInfoRouteList : TeaModel {
                /// <summary>
                /// <para>The creation time, which is a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Route destination CIDR</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("DestinationCidr")]
                [Validation(Required=false)]
                public string DestinationCidr { get; set; }

                /// <summary>
                /// <para>Route ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Network Resource ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public long? NetworkId { get; set; }

                /// <summary>
                /// <para>Unique identifier of the resource group to which it belongs</para>
                /// 
                /// <b>Example:</b>
                /// <para>Serverless_res_group_524257424564736_6831777003****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Unique identifier of network resource</para>
                /// 
                /// <b>Example:</b>
                /// <para>ns-679XXXXXX</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

            /// <summary>
            /// <para>All data entries</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. It is used to locate logs and troubleshoot problems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
