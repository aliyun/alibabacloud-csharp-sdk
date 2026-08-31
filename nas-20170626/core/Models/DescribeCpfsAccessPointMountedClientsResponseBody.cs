// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeCpfsAccessPointMountedClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The clients mounted to the access point.</para>
        /// </summary>
        [NameInMap("MountedClient")]
        [Validation(Required=false)]
        public List<DescribeCpfsAccessPointMountedClientsResponseBodyMountedClient> MountedClient { get; set; }
        public class DescribeCpfsAccessPointMountedClientsResponseBodyMountedClient : TeaModel {
            /// <summary>
            /// <para>The type of the client mounted to the access point. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>vsc</description></item>
            /// <item><description>tcp</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsc</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The ID of the client mounted to the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-8vb864o3ppwfvh****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The IP address of the client mounted to the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>219.145.34.210</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results on each page. Valid values: 1 to 100. Default value: 10.</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of clients mounted to the access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
