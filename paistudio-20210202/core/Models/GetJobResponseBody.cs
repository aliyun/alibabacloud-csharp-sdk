// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// <para>arguments:
        ///   parameters:</para>
        /// <list type="bullet">
        /// <item><description>name: &quot;execution_maxcompute&quot;
        /// value:
        ///   endpoint: &quot;<a href="http://service.cn-shanghai.maxcompute.aliyun.com/api">http://service.cn-shanghai.maxcompute.aliyun.com/api</a>&quot;
        ///   odpsProject: &quot;xxxxxxx&quot;</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Arguments")]
        [Validation(Required=false)]
        public string Arguments { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13266*******76250</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXECUTE_TO_HERE</para>
        /// </summary>
        [NameInMap("ExecuteType")]
        [Validation(Required=false)]
        public string ExecuteType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>draft-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-6xfhrofqx93y139fg3</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id-xxxxx</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>node-5dzotrnwyzfxmbwwc8</para>
        /// </summary>
        [NameInMap("PaiflowNodeId")]
        [Validation(Required=false)]
        public string PaiflowNodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flow-lcs8ez11961l6urc3m</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apiVersion: &quot;core/v1&quot;
        /// metadata:
        ///   version: &quot;v1&quot;
        ///   identifier: &quot;1de8f7c8-a9d8-4433-9e87-d95979ccab14&quot;
        ///   annotations: {}
        /// spec:
        ///   inputs:
        ///     artifacts: []
        ///     parameters:
        ///     - name: &quot;execution&quot;
        ///       type: &quot;Map&quot;
        ///   arguments:
        ///     artifacts: []
        ///     parameters: []
        ///   dependencies: []
        ///   initContainers: []
        ///   sideCarContainers: []
        ///   pipelines:</para>
        /// <list type="bullet">
        /// <item><description>apiVersion: &quot;core/v1&quot;
        /// metadata:
        ///   provider: &quot;pai&quot;
        ///   name: &quot;id-2d88-1608982098027-91558&quot;
        ///   version: &quot;v1&quot;
        ///   identifier: &quot;type_transform&quot;
        ///   annotations: {}</description></item>
        /// </list>
        /// </summary>
        [NameInMap("RunInfo")]
        [Validation(Required=false)]
        public string RunInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Snapshot")]
        [Validation(Required=false)]
        public string Snapshot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86995</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
