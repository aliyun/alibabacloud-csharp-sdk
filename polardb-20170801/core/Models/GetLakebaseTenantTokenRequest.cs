// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GetLakebaseTenantTokenRequest : TeaModel {
        /// <summary>
        /// <para>The associated PolarDB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The mount subdirectory. Specify an absolute path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/project/p1</para>
        /// </summary>
        [NameInMap("Subdir")]
        [Validation(Required=false)]
        public string Subdir { get; set; }

        /// <summary>
        /// <para>The tenant identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant-xxx</para>
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

    }

}
