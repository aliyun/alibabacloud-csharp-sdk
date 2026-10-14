// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateProcessDefinitionWithScheduleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The alert email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:foo_bar@spark.alert.invalid.com">foo_bar@spark.alert.invalid.com</a></para>
        /// </summary>
        [NameInMap("alertEmailAddress")]
        [Validation(Required=false)]
        public string AlertEmailAddress { get; set; }

        /// <summary>
        /// <para>The workflow description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods batch workflow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARALLEL</para>
        /// </summary>
        [NameInMap("executionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

        [NameInMap("globalParams")]
        [Validation(Required=false)]
        public string GlobalParamsShrink { get; set; }

        /// <summary>
        /// <para>The workflow name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_batch_workflow</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SS</para>
        /// </summary>
        [NameInMap("productNamespace")]
        [Validation(Required=false)]
        public string ProductNamespace { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("publish")]
        [Validation(Required=false)]
        public bool? Publish { get; set; }

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
        /// <para>The online status of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONLINE</para>
        /// </summary>
        [NameInMap("releaseState")]
        [Validation(Required=false)]
        public string ReleaseState { get; set; }

        /// <summary>
        /// <para>The resource queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("resourceQueue")]
        [Validation(Required=false)]
        public string ResourceQueue { get; set; }

        /// <summary>
        /// <para>The number of retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("retryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// <para>The execution user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113***************</para>
        /// </summary>
        [NameInMap("runAs")]
        [Validation(Required=false)]
        public string RunAs { get; set; }

        /// <summary>
        /// <para>The scheduling structure.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public string ScheduleShrink { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The JSON array of node definitions, which contains the description information of all nodes in the workflow.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskDefinitionJson")]
        [Validation(Required=false)]
        public string TaskDefinitionJsonShrink { get; set; }

        /// <summary>
        /// <para>The concurrency of workflow node execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("taskParallelism")]
        [Validation(Required=false)]
        public int? TaskParallelism { get; set; }

        /// <summary>
        /// <para>The JSON array of node dependencies, which contains the dependencies among all nodes in the workflow. preTaskCode is the upstream node ID, and postTaskCode is the downstream node ID. Each node must have a unique ID. If a node does not have an upstream node, you must add a dependency with preTaskCode set to 0.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskRelationJson")]
        [Validation(Required=false)]
        public string TaskRelationJsonShrink { get; set; }

        /// <summary>
        /// <para>The default timeout for workflow execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
