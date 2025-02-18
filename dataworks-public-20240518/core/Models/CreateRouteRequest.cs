// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateRouteRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR blocks of the destination-based route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("DestinationCidr")]
        [Validation(Required=false)]
        public string DestinationCidr { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public long? NetworkId { get; set; }

    }

}
