// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Ray Job (exact match).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myrayjob</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The submission ID of the Ray Job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rj-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("submissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// <para>The submit time range.</para>
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public ListRayJobRequestSubmitTime SubmitTime { get; set; }
        public class ListRayJobRequestSubmitTime : TeaModel {
            /// <summary>
            /// <para>The end of the submit time range. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780018822000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start of the submit time range. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780017822000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The data development node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TSK-db8b870d901e443ba0aebba40c923e02</para>
        /// </summary>
        [NameInMap("taskBizId")]
        [Validation(Required=false)]
        public string TaskBizId { get; set; }

    }

}
