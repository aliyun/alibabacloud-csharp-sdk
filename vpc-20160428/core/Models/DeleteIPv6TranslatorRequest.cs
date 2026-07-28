// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteIPv6TranslatorRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientToken</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPv6 Translation Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1i8ahxut1ie****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the IPv6 Translation Service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
