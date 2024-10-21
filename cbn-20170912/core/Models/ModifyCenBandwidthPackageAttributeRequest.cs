// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyCenBandwidthPackageAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cenbwp-4c2zaavbvh5fx****</para>
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The new description of the bandwidth plan.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bandwidth Plans</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new name of the bandwidth plan.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

    }

}
