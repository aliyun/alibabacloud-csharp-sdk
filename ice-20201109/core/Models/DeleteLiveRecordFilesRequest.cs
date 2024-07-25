// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveRecordFilesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<string> RecordIds { get; set; }

        [NameInMap("RemoveFile")]
        [Validation(Required=false)]
        public bool? RemoveFile { get; set; }

    }

}
