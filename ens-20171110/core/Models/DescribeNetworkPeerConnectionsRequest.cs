// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkPeerConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ENS node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the network peer connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcc-5inkeimcipxk26yqtzm4q****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the network peer connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of the networks involved in the connection. The query does not distinguish between the requester and accepter.</para>
        /// </summary>
        [NameInMap("NetworkIds")]
        [Validation(Required=false)]
        public List<string> NetworkIds { get; set; }

        /// <summary>
        /// <para>The page number for the returned results. Default: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default: <b>10</b>. Valid values: <b>10</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
