// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of timestamps when the jobs were created. The values are UNIX timestamps representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A maximum of 200 jobs can be deleted at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateTimestampList")]
        [Validation(Required=false)]
        public string CreateTimestampListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the original files at the same time. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteOriginalFile")]
        [Validation(Required=false)]
        public bool? DeleteOriginalFile { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
