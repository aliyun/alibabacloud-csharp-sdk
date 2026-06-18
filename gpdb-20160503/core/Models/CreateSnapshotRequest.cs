// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence token. Ensures that repeated requests do not result in duplicate operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The LSN for the snapshot. You must specify either this parameter or SnapshotTimestamp. If this parameter is specified, the snapshot is created based on the specified LSN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/3522648</para>
        /// </summary>
        [NameInMap("Lsn")]
        [Validation(Required=false)]
        public string Lsn { get; set; }

        /// <summary>
        /// <para>The Supabase project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID. Specifies the region in which to perform the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The point in time for the snapshot. You must specify either this parameter or Lsn. If this parameter is specified, the snapshot is created based on the specified point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("SnapshotTimestamp")]
        [Validation(Required=false)]
        public string SnapshotTimestamp { get; set; }

    }

}
