// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. It ensures that duplicate requests do not execute the same operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The log sequence number (LSN) for the snapshot. You must specify either this parameter or SnapshotTimestamp. If specified, the snapshot is created based on this LSN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/3522648</para>
        /// </summary>
        [NameInMap("Lsn")]
        [Validation(Required=false)]
        public string Lsn { get; set; }

        /// <summary>
        /// <para>The ID of the Supabase project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The point in time for the snapshot. You must specify either this parameter or Lsn. If specified, the snapshot is created based on this point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("SnapshotTimestamp")]
        [Validation(Required=false)]
        public string SnapshotTimestamp { get; set; }

    }

}
