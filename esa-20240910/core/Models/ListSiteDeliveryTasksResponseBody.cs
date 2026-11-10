// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSiteDeliveryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Valid values: <b>1 to 500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34DCBC8A-<b><b>-</b></b>-****-6DAA11D7DDBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListSiteDeliveryTasksResponseBodyTasks> Tasks { get; set; }
        public class ListSiteDeliveryTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The real-time log type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>dcdn_log_access_l1</b> (default): Access logs.</description></item>
            /// <item><description><b>dcdn_log_er</b>: Edge Routine logs.</description></item>
            /// <item><description><b>dcdn_log_waf</b>: Security protection logs.</description></item>
            /// <item><description><b>dcdn_log_ipa</b>: Layer 4 acceleration logs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn_log_access_l1</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The data center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: The Chinese mainland.</description></item>
            /// <item><description><b>sg</b>: Global (excluding the Chinese mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            /// <summary>
            /// <para>The delivery type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sls</b>: Simple Log Service.</description></item>
            /// <item><description><b>http</b>: HTTP service.</description></item>
            /// <item><description><b>aws3</b>: Amazon S3 service.</description></item>
            /// <item><description><b>oss</b>: Object Storage Service (OSS).</description></item>
            /// <item><description><b>kafka</b>: Kafka service.</description></item>
            /// <item><description><b>aws3cmpt</b>: Amazon S3-compatible service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: Pushing.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: Paused.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn-test-task</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The total number of real-time log projects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
