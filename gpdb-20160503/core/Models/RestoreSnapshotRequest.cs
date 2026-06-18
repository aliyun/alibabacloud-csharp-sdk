// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RestoreSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence token. Ensures that repeated requests do not execute the same operation more than once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to complete the restoration immediately. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FinalizeRestore")]
        [Validation(Required=false)]
        public bool? FinalizeRestore { get; set; }

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
        /// <para>The region ID. Specifies the region in which to query or perform the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the restored branch. If not specified, the backend generates a name automatically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>restore_preview</para>
        /// </summary>
        [NameInMap("RestoredBranchName")]
        [Validation(Required=false)]
        public string RestoredBranchName { get; set; }

        /// <summary>
        /// <para>The snapshot LSN used for restoration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/3522648</para>
        /// </summary>
        [NameInMap("RestoredLsn")]
        [Validation(Required=false)]
        public string RestoredLsn { get; set; }

        /// <summary>
        /// <para>The target branch ID. If not specified, the backend selects the target branch based on the restoration process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-main</para>
        /// </summary>
        [NameInMap("TargetBranchId")]
        [Validation(Required=false)]
        public string TargetBranchId { get; set; }

    }

}
