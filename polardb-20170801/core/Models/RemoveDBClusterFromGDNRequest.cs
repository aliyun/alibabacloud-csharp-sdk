// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RemoveDBClusterFromGDNRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the secondary cluster that you want to remove from the GDN.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/264580.html">DescribeGlobalDatabaseNetwork</a> operation to query the IDs of clusters in the GDN.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz9fb5nn44u1d****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly remove the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the GDN.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-bp1fttxsrmv*****</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the target cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz9fb5nn44u1d****</para>
        /// </summary>
        [NameInMap("TargetDBClusterId")]
        [Validation(Required=false)]
        public string TargetDBClusterId { get; set; }

    }

}
