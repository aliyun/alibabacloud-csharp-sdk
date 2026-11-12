// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EnableAIDBClusterDatasetServiceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the PolarFS cold storage instance that you attach to the dataset management service. Instructions to invoke: Note: This parameter is actually required. If it is not provided, the API returns InvalidDBClusterId.Malformed (400). Instructions to invoke: Valid ID format description: specifies the accepted prefix families (such as pcs-xxx), separator conventions (hyphen character vs. underscore character), and the corresponding resource types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-2ze26***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the database instance that you attach to the dataset management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
