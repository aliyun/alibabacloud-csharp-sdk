// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class BindInputBucketRequest : TeaModel {
        /// <summary>
        /// <para>The name of the input media bucket to be bound. The name can be up to 64 bytes in size. To obtain the media bucket name, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Media Buckets</b> in the left-side navigation pane.</para>
        /// <remarks>
        /// <para>The bucket name can contain lowercase letters, digits, and hyphens (-), and cannot start or end with a hyphen (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket-****</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The settings of Object Storage Service (OSS) hotlink protection. For more information, see <a href="https://help.aliyun.com/document_detail/31869.html">Hotlink protection</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">http://www.example.com</a></para>
        /// </summary>
        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
