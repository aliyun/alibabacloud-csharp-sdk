// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class UpdateKVCacheStoreRequest : TeaModel {
        /// <summary>
        /// <para>The new storage capacity in GiB. The value must be a multiple of 300 TiB and greater than the current capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YOUR_CLIENT_TOKEN</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The new KVCacheStore description. The description must be 2 to 256 characters in length and can contain English and Chinese characters. The description cannot start with http:// or https://. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project name pass the check</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The KVCacheStore instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcs-your-id</para>
        /// </summary>
        [NameInMap("KvcsId")]
        [Validation(Required=false)]
        public string KvcsId { get; set; }

        /// <summary>
        /// <para>The new KVCacheStore name. The name must be 2 to 128 characters in length and can contain characters that are categorized as letter in Unicode (including English and Chinese characters) and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-). If this parameter is not specified, the default value is the KVCacheStore ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633730290118313-HD-m3u8</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource tag key-value pairs. A maximum of 20 tags are supported.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateKVCacheStoreRequestTag> Tag { get; set; }
        public class UpdateKVCacheStoreRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projectId</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projectName</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
