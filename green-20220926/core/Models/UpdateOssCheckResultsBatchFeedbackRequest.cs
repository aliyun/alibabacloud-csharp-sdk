// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateOssCheckResultsBatchFeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>misreport</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>The result items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public string Items { get; set; }

        /// <summary>
        /// <para>The ID of the parent task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P_XHDUS</para>
        /// </summary>
        [NameInMap("ParentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

    }

}
