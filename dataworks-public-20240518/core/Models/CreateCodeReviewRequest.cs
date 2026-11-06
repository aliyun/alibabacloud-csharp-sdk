// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCodeReviewRequest : TeaModel {
        /// <summary>
        /// <para>The description of the code review. The maximum length is 1,024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code review</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of a single release pipeline.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pipeline-id</para>
        /// </summary>
        [NameInMap("PipelineRunId")]
        [Validation(Required=false)]
        public string PipelineRunId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23620</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies the reviewers. Separate multiple accounts with commas (,). At least one reviewer is required, and the maximum length is 512 characters after deduplication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456,2345678901234567</para>
        /// </summary>
        [NameInMap("Reviewers")]
        [Validation(Required=false)]
        public string Reviewers { get; set; }

    }

}
