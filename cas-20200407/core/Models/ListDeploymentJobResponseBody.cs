// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data returned by the API.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain names included in the certificate of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc1.com,aliyundoc2.com,aliyundoc3.com</para>
            /// </summary>
            [NameInMap("CertDomain")]
            [Validation(Required=false)]
            public string CertDomain { get; set; }

            /// <summary>
            /// <para>The certificate type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>upload</b>: uploaded certificate</description></item>
            /// <item><description><b>buy</b>: purchased certificate</description></item>
            /// <item><description><b>free</b>: personal test certificate (supported only on the China site)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>upload</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The deletion flag. This parameter has no practical significance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not deleted.</description></item>
            /// <item><description><b>1</b>: deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Del")]
            [Validation(Required=false)]
            public int? Del { get; set; }

            /// <summary>
            /// <para>The end time of the deployment task execution, in UNIX timestamp format (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the deployment task was created, in UNIX timestamp format (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624343180000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the deployment task was last modified, in UNIX timestamp format (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The deployment task ID. You can use this ID to query the deployment task details and status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19975</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-job-user-***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloud</b>: multi-cloud deployment task.</description></item>
            /// <item><description><b>user</b>: cloud service deployment task (excluding ECS instances).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The name of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cloud services included in the deployment task resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Indicates whether the task contains a rollback worker. For example, if a cloud service in the task has been rolled back, the value <b>1</b> is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: does not contain a rollback worker.</description></item>
            /// <item><description><b>1</b>: contains a rollback worker.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public int? Rollback { get; set; }

            /// <summary>
            /// <para>The scheduled time of the task, in UNIX timestamp format (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The start time of the deployment task execution, in UNIX timestamp format (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The deployment task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: pending execution.</description></item>
            /// <item><description><b>editing</b>: being edited.</description></item>
            /// <item><description><b>scheduling</b>: being scheduled.</description></item>
            /// <item><description><b>processing</b>: being deployed.</description></item>
            /// <item><description><b>error</b>: deployment failed.</description></item>
            /// <item><description><b>success</b>: deployment succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user account ID (UID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>166688437*****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of deployment tasks per page. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of deployment tasks returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
