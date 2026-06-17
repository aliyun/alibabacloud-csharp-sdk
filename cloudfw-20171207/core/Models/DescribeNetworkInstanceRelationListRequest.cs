// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkInstanceRelationListRequest : TeaModel {
        /// <summary>
        /// <para>The connection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen</para>
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// <para>The configuration status of Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notconfigured</para>
        /// </summary>
        [NameInMap("FirewallConfigureStatus")]
        [Validation(Required=false)]
        public string FirewallConfigureStatus { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the local network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2vcwkr****</para>
        /// </summary>
        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the peer network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-dsf232d****</para>
        /// </summary>
        [NameInMap("PeerNetworkInstanceId")]
        [Validation(Required=false)]
        public string PeerNetworkInstanceId { get; set; }

    }

}
