// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListWorkflowTasksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        [NameInMap("KeyText")]
        [Validation(Required=false)]
        public string KeyText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****<b><b><b><b><b>VRpbWUQARgBIpcBCgkA1bUtaAAAAAAKiQEDhAAAADFTMzg2NTY2NjU2MzM3NjU2NjYyMzkzMTYyMzI2MjYzNjY2</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-12T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>b4fb044839815d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example-workflow-****</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
