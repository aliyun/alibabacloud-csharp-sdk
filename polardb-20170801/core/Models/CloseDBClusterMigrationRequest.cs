// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CloseDBClusterMigrationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to continue to enable binary logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: continues to enable binary logging.</description></item>
        /// <item><description><b>false</b>: disables binary logging.</description></item>
        /// </list>
        /// <para>Default value: <b>true</b>.</para>
        /// <remarks>
        /// <para>If binary logging is disabled, your PolarDB cluster is restarted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ContinueEnableBinlog")]
        [Validation(Required=false)]
        public bool? ContinueEnableBinlog { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
