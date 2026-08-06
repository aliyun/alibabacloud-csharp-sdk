// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyInstanceGroupSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The order information.</para>
        /// </summary>
        [NameInMap("OrderInfo")]
        [Validation(Required=false)]
        public List<ModifyInstanceGroupSpecResponseBodyOrderInfo> OrderInfo { get; set; }
        public class ModifyInstanceGroupSpecResponseBodyOrderInfo : TeaModel {
            /// <summary>
            /// <para>The list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>296325540190****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The order task ID that is returned when specifications of more than 10 instance groups are changed in a batch. You can call the <b>DescribeOrderTasks</b> operation to query the information about each order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-aycabdsjsbgd****</para>
        /// </summary>
        [NameInMap("OrderTaskId")]
        [Validation(Required=false)]
        public string OrderTaskId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
