// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayJobShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>myrayjob</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rj-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("submissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTimeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TSK-db8b870d901e443ba0aebba40c923e02</para>
        /// </summary>
        [NameInMap("taskBizId")]
        [Validation(Required=false)]
        public string TaskBizId { get; set; }

    }

}
