// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateDatasetFileMetasResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of file metadata that failed to be updated.</para>
        /// </summary>
        [NameInMap("FailedDetails")]
        [Validation(Required=false)]
        public List<DatasetFileMetaResponse> FailedDetails { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the batch metadata update. A value of \<c>true\\</c> indicates that all updates succeeded. If the value is \<c>false\\</c>, check the \<c>FailedDetails\\</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
