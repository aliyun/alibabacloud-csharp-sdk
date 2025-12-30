// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListTransferFileDownloadUrlRequest : TeaModel {
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trt-hffhi4nmqoi4****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
