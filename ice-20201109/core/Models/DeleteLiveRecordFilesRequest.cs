// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveRecordFilesRequest : TeaModel {
        /// <summary>
        /// <para>The collection of IDs of recording files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<string> RecordIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the original files in OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RemoveFile")]
        [Validation(Required=false)]
        public bool? RemoveFile { get; set; }

    }

}
