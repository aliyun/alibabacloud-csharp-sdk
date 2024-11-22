// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserDeliveryTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>1f94c47f-3a1a-4f69-8d6c-bfeee1b49aab</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The delivery tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListUserDeliveryTasksResponseBodyTasks> Tasks { get; set; }
        public class ListUserDeliveryTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The log category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn_log_er</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The data center. Valid values:</para>
            /// <ol>
            /// <item><description>cn: the Chinese mainland.</description></item>
            /// <item><description>sg: outside the Chinese mainland.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            /// <summary>
            /// <para>The delivery destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <para>The status of the delivery task.</para>
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
            /// <para>testoss11</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The total number of delivery tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
