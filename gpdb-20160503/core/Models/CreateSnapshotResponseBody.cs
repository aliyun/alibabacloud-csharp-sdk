// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>The branch ID to which the snapshot belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-xxxx</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The actual point in time that corresponds to the created snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
