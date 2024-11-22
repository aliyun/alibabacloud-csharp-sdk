// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSiteDeliveryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 500</b>. Default value: <b>20</b>.</para>
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
        /// <para>The delivery tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListSiteDeliveryTasksResponseBodyTasks> Tasks { get; set; }
        public class ListSiteDeliveryTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The log category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dcdn_log_access_l1 (default): access logs.</description></item>
            /// <item><description>dcdn_log_er: Edge Routine logs.</description></item>
            /// <item><description>dcdn_log_waf: firewall logs.</description></item>
            /// <item><description>dcdn_log_ipa: TCP/UDP proxy logs.</description></item>
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
            /// <item><description>cn: the Chinese mainland.</description></item>
            /// <item><description>sg: outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            /// <summary>
            /// <para>The destination of the delivery. Valid values:</para>
            /// <ol>
            /// <item><description>sls: Alibaba Cloud Simple Log Service (SLS).</description></item>
            /// <item><description>http: HTTP server.</description></item>
            /// <item><description>aws3: Amazon Simple Storage Service (S3).</description></item>
            /// <item><description>oss: Alibaba Cloud Object Storage Service (OSS).</description></item>
            /// <item><description>kafka: Kafka.</description></item>
            /// <item><description>aws3cmpt: S3-compatible storage service.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <para>The status of the delivery task.</para>
            /// <list type="bullet">
            /// <item><description><b>online</b></description></item>
            /// <item><description><b>offline</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the delivery task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn-test-task</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The total number of log delivery tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
