// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ReleaseReadWriteSplittingConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the primary instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The type of the read/write splitting endpoint to be released. Valid values: ReadOnlyAddress (unified read-only endpoint) and BackupAddress (read-only endpoint of the secondary instance).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadOnlyAddress</para>
        /// </summary>
        [NameInMap("RWAddressType")]
        [Validation(Required=false)]
        public string RWAddressType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
