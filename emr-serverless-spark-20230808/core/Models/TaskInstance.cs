// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class TaskInstance : TeaModel {
        /// <summary>
        /// <para>The ID of the folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-d8********</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The ID of the user who creates the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150978934701****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        /// <summary>
        /// <para>The job run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jr-93d98d2f7061****</para>
        /// </summary>
        [NameInMap("fenixRunId")]
        [Validation(Required=false)]
        public string FenixRunId { get; set; }

        /// <summary>
        /// <para>The time when the job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-05T02:03:19Z</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The ID of the data development job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TSK-d87******************</para>
        /// </summary>
        [NameInMap("taskBizId")]
        [Validation(Required=false)]
        public string TaskBizId { get; set; }

        /// <summary>
        /// <para>The details of the job.</para>
        /// </summary>
        [NameInMap("taskInfo")]
        [Validation(Required=false)]
        public Task TaskInfo { get; set; }

        /// <summary>
        /// <para>The job run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-d2d82aa09151****</para>
        /// </summary>
        [NameInMap("workspaceBizId")]
        [Validation(Required=false)]
        public string WorkspaceBizId { get; set; }

    }

}
