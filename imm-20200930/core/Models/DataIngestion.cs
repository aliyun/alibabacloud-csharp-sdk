// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DataIngestion : TeaModel {
        /// <summary>
        /// <para>A list of processing templates.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<DataIngestionActions> Actions { get; set; }
        public class DataIngestionActions : TeaModel {
            /// <summary>
            /// <para>The configuration of the fast-fail policy for data processing.</para>
            /// </summary>
            [NameInMap("FastFailPolicy")]
            [Validation(Required=false)]
            public FastFailPolicy FastFailPolicy { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc/convert</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template parameters.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-10T03:50:28Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api returns error: SDKError: StatusCode: 404 Code: ResourceNotFound</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The unique ID of the data ingestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trigger-9f72636a-0f0c-4baf-ae78-38b27bfe****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The data source information.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        /// <summary>
        /// <para>The task execution position.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpw****</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The notification for task completion.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public DataIngestionNotification Notification { get; set; }
        public class DataIngestionNotification : TeaModel {
            /// <summary>
            /// <para>The MNS Endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://1111111111.mns.cn-hangzhou.aliyuncs.com">http://1111111111.mns.cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>MNS</para>
            /// </summary>
            [NameInMap("MNS")]
            [Validation(Required=false)]
            public MNS MNS { get; set; }

            /// <summary>
            /// <para>RocketMQ</para>
            /// </summary>
            [NameInMap("RocketMQ")]
            [Validation(Required=false)]
            public RocketMQ RocketMQ { get; set; }

            /// <summary>
            /// <para>The MNS topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic1</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The scanning phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IncrementalScanning</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The service authorization role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunIMMBatchTriggerRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// <para>The state of the batch processing task:</para>
        /// <list type="bullet">
        /// <item><description><para>Ready: The task is ready. A newly created task is in the Ready state.</para>
        /// </description></item>
        /// <item><description><para>Running: The task is running. This is the state of a task that is executing normally.</para>
        /// </description></item>
        /// <item><description><para>Failed: The task failed. An error occurred during task execution, and the task cannot be automatically recovered.</para>
        /// </description></item>
        /// <item><description><para>Suspended: The task is paused.</para>
        /// </description></item>
        /// <item><description><para>Succeeded: The task is complete.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The statistics information.</para>
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public DataIngestionStatistic Statistic { get; set; }
        public class DataIngestionStatistic : TeaModel {
            /// <summary>
            /// <para>The number of skipped files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SkipFiles")]
            [Validation(Required=false)]
            public long? SkipFiles { get; set; }

            /// <summary>
            /// <para>The number of failed submissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubmitFailure")]
            [Validation(Required=false)]
            public long? SubmitFailure { get; set; }

            /// <summary>
            /// <para>The number of successful submissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SubmitSuccess")]
            [Validation(Required=false)]
            public long? SubmitSuccess { get; set; }

        }

        /// <summary>
        /// <para>The task tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The time when the task was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-18T07:40:29Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
