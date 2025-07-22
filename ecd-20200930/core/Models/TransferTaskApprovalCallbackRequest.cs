// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class TransferTaskApprovalCallbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ed****-17337752804***</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("OssBucketRegionId")]
        [Validation(Required=false)]
        public string OssBucketRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trt-msndfksm18fs****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
