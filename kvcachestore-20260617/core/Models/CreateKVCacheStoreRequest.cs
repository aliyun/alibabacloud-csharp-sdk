// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class CreateKVCacheStoreRequest : TeaModel {
        /// <summary>
        /// <para>The storage capacity in GiB. The minimum capacity is 300 TiB (307200 GiB), and the capacity is scaled in increments of 300 TiB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2395</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The client token used to ensure idempotence of the request. The token can be up to 64 characters in length. Use a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YOUR_CLIENT_TOKEN</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The KVCacheStore description. The description must be 2 to 256 characters in length and cannot start with http:// or https://. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The HPN cluster ID, which is used to create an affinity scheduling relationship between the KVCacheStore and the specified HPN cluster. After creation, the KVCacheStore may have affinity relationships with multiple HPN clusters based on network topology. You can call GetKVCacheStore to query the available HPN clusters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>The KVCacheStore name. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including English and Chinese characters) and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-). If this parameter is not specified, the default value is the KVCacheStore ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc-data-warehouse-server</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: POSTPAY (pay-as-you-go). Default value: POSTPAY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The region ID in which to create the KVCacheStore. You can call DescribeRegions to query the list of available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzafsjd7i4qaq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resource tag key-value pairs. A maximum of 20 tags are supported. This overrides the parent TagDTO type and uses the same Tag type as the Get/List response.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateKVCacheStoreRequestTag> Tag { get; set; }
        public class CreateKVCacheStoreRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000098da1005a3df</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000088aabb0023f7</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The zone ID. You can call DescribeZones to query the list of zones in the specified region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
