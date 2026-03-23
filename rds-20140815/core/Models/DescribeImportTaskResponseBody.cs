// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeImportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myadmin</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>Milvus version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("DbVersion")]
        [Validation(Required=false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// <para>Detailed information about the job</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error Message</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A103039D-B1B2-4C57-B989-7D7C0DA95426</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Source instance category.  </para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Alibaba Cloud ECS.  </description></item>
        /// <item><description><b>other</b>: Other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunRDS</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>Source IP address for access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.172.25.122</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Source MySQL port</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public string SourcePort { get; set; }

        /// <summary>
        /// <para>Task Status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Importing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Name of the target disaster recovery instance to switch to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4neh0q12v1******</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>Job ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>416980000</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>Task Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Task Type, used to query jobs of specific types. Separate multiple types with commas. A maximum of 30 types are supported. The default value is empty, indicating no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
