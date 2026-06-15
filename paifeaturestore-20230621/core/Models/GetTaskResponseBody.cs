// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The task configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;mode&quot;: &quot;overwrite&quot;,
        ///     &quot;partitions&quot;: {
        ///         &quot;dt&quot;: &quot;20230820&quot;
        ///     },
        ///     &quot;event_time&quot;: &quot;&quot;,
        ///     &quot;config&quot;: {},
        ///     &quot;offline_to_online&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The execution time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtExecutedTime")]
        [Validation(Required=false)]
        public string GmtExecutedTime { get; set; }

        /// <summary>
        /// <para>The completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtFinishedTime")]
        [Validation(Required=false)]
        public string GmtFinishedTime { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the target object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The type of the target object.</para>
        /// <list type="bullet">
        /// <item><description><para>ModelFeature: model feature</para>
        /// </description></item>
        /// <item><description><para>FeatureView: feature view</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ModelFeature</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37D19490-AB69-567D-A852-407C94E510E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task runtime configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DROP TABLE IF EXISTS public.fsxxx</para>
        /// </summary>
        [NameInMap("RunningConfig")]
        [Validation(Required=false)]
        public string RunningConfig { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
        /// <list type="bullet">
        /// <item><description><para>Initializing: The task is initializing.</para>
        /// </description></item>
        /// <item><description><para>Running: The task is running.</para>
        /// </description></item>
        /// <item><description><para>Success: The task completed successfully.</para>
        /// </description></item>
        /// <item><description><para>Failure: The task failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <list type="bullet">
        /// <item><description><para>OfflineToOnline: offline-to-online data synchronization</para>
        /// </description></item>
        /// <item><description><para>ExportTrainingSet: training sample table export</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OfflineToOnline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
