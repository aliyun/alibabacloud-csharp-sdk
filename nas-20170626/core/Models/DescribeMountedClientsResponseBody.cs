// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountedClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried clients.</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public DescribeMountedClientsResponseBodyClients Clients { get; set; }
        public class DescribeMountedClientsResponseBodyClients : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public List<DescribeMountedClientsResponseBodyClientsClient> Client { get; set; }
            public class DescribeMountedClientsResponseBodyClientsClient : TeaModel {
                /// <summary>
                /// <para>The IP address of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.10.1</para>
                /// </summary>
                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

            }

        }

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
        /// <para>The number of IP addresses returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A70BEE5D-76D3-49FB-B58F-1F398211****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
