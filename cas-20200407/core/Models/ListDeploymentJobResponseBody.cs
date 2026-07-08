// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data returned for the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain names bound to the certificate of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc1.com,aliyundoc2.com,aliyundoc3.com</para>
            /// </summary>
            [NameInMap("CertDomain")]
            [Validation(Required=false)]
            public string CertDomain { get; set; }

            /// <summary>
            /// <para>The type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>upload</b>: uploaded certificate</para>
            /// </description></item>
            /// <item><description><para><b>buy</b>: purchased certificate</para>
            /// </description></item>
            /// <item><description><para><b>free</b>: free certificate, available only on the China site (aliyun.com)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>upload</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>Indicates whether the deployment task is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: not deleted</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: deleted</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Del")]
            [Validation(Required=false)]
            public int? Del { get; set; }

            /// <summary>
            /// <para>The end time of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the deployment task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624343180000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the deployment task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the deployment task. You can use the ID to query the details and status of the deployment task.</para>
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
            /// <para>The type of the deployment task.</para>
            /// <list type="bullet">
            /// <item><description><para><b>cloud</b>: multi-cloud deployment task.</para>
            /// </description></item>
            /// <item><description><para><b>user</b>: cloud service deployment task. This type of task does not support ECS instances.</para>
            /// </description></item>
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
            /// <para>The cloud service included in the resources of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Indicates whether the rollback worker is included. For example, if a cloud service involved in a deployment task has been rolled back, <b>1</b> is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The rollback worker is not included.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The rollback worker is included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public int? Rollback { get; set; }

            /// <summary>
            /// <para>The time when the deployment task was scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>The start time of the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606482979000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the deployment task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pending</b></para>
            /// </description></item>
            /// <item><description><para><b>editing</b></para>
            /// </description></item>
            /// <item><description><para><b>scheduling</b></para>
            /// </description></item>
            /// <item><description><para><b>processing</b></para>
            /// </description></item>
            /// <item><description><para><b>error</b></para>
            /// </description></item>
            /// <item><description><para><b>success</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scheduling</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>166688437*****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
