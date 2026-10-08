// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeImportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myadmin</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The Milvus version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("DbVersion")]
        [Validation(Required=false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// <para>The detailed information about the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error Message</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A103039D-B1B2-4C57-B989-7D7C0DA95426</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The category of the source instance.</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Alibaba Cloud ECS.</description></item>
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
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.172.25.122</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The source MySQL port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public string SourcePort { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Importing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the destination disaster recovery instance for the switchover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4neh0q12v1******</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>416980000</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is used to query tasks of specific types. Separate multiple task types with commas (,). A maximum of 30 task types are supported. If this parameter is left empty, tasks of all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
