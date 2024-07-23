// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UnbindInputBucketRequest : TeaModel {
        /// <summary>
        /// <para>The name of the input media bucket to be unbound. To obtain the media bucket name, you can log on to the <b>ApsaraVideo Media Processing (MPS) console</b> and choose <b>Workflows</b> &gt; <b>Media Buckets</b> in the left-side navigation pane. Alternatively, you can log on to the <b>Object Storage Service (OSS) console</b> and click <b>Historical Paths</b>.</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the role used for delegated authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::174809843091****:role/exampleRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
