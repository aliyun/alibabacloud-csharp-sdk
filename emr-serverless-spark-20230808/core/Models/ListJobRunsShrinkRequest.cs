// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Spark configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;key\&quot;:\&quot;spark.app.name\&quot;,\&quot;value\&quot;:\&quot;test\&quot;}]</para>
        /// </summary>
        [NameInMap("applicationConfigs")]
        [Validation(Required=false)]
        public string ApplicationConfigs { get; set; }

        /// <summary>
        /// <para>The UID of the user who created the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150976534701****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The time range when the job run ended.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTimeShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the job is a workflow task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isWorkflow")]
        [Validation(Required=false)]
        public string IsWorkflow { get; set; }

        /// <summary>
        /// <para>The deployment ID of the streaming job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jd-b6d003f1930f****</para>
        /// </summary>
        [NameInMap("jobRunDeploymentId")]
        [Validation(Required=false)]
        public string JobRunDeploymentId { get; set; }

        /// <summary>
        /// <para>The job run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-xxx</para>
        /// </summary>
        [NameInMap("jobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The minimum runtime of the job run, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("minDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr-spark-demo-job</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which to start the next read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource queue on which the Spark job runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// <para>The runtime configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;key\&quot;:\&quot;mainClass\&quot;,\&quot;value\&quot;:\&quot;yourClass\&quot;}]</para>
        /// </summary>
        [NameInMap("runtimeConfigs")]
        [Validation(Required=false)]
        public string RuntimeConfigs { get; set; }

        /// <summary>
        /// <para>The time range when the job run started.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTimeShrink { get; set; }

        /// <summary>
        /// <para>The job run states.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Running&quot;,&quot;Submitted&quot;]</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public string StatesShrink { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
