// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteIPv6TranslatorEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 mapping entry to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transentry-bp1g8bhrde****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorEntryId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorEntryId { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 Translation Service instance.</para>
        /// <remarks>
        /// <para>If you do not specify <b>Ipv6TranslatorEntryId</b>, all mapping entries in the specified instance are deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1858ys****</para>
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
        /// <para>The region of the IPv6 Translation Service instance. You can call the <b>DescribeRegions</b> operation to query the most recent region list.</para>
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
