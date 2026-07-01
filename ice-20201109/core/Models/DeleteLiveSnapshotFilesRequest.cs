// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesRequest : TeaModel {
        /// <summary>
        /// <para>A list of creation timestamps for the files to delete. You can specify up to 200 timestamps per request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateTimestampList")]
        [Validation(Required=false)]
        public List<long?> CreateTimestampList { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the original OSS files. The default value is false.</para>
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
