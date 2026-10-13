// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SubmitScriptPreReviewResultRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the script review record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b8e1a4d3-9c2f-4e6a-b7d5-3f1e2a4c6b8d</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The reason for pre-review rejection. This parameter is required when ReviewResult is set to REJECT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The script content involves sensitive information</para>
        /// </summary>
        [NameInMap("RejectReason")]
        [Validation(Required=false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// <para>The pre-review result. Valid values: PASS (approved) and REJECT (rejected). The value is not case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PASS</para>
        /// </summary>
        [NameInMap("ReviewResult")]
        [Validation(Required=false)]
        public string ReviewResult { get; set; }

    }

}
