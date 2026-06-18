// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateGdnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FASTJSON 2.0.x has been released, faster and more secure, recommend you upgrade.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The GDN mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn_mode_master_slave, gdn_mode_bidirectional</para>
        /// </summary>
        [NameInMap("GdnMode")]
        [Validation(Required=false)]
        public string GdnMode { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The conflict strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECT_OVERWRITE, OVERWRITE, IGNORE, INTERRUPT</para>
        /// </summary>
        [NameInMap("RplConflictStrategy")]
        [Validation(Required=false)]
        public string RplConflictStrategy { get; set; }

        /// <summary>
        /// <para>The DML replication policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MERGE,  SERIAL, TRANSACTION, SPLIT</para>
        /// </summary>
        [NameInMap("RplDmlStrategy")]
        [Validation(Required=false)]
        public string RplDmlStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize DDL statements.</para>
        /// </summary>
        [NameInMap("RplSyncDdl")]
        [Validation(Required=false)]
        public bool? RplSyncDdl { get; set; }

    }

}
