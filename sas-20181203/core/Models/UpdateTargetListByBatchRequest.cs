// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateTargetListByBatchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the release batch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52370</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>The operations on assets.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperationList")]
        [Validation(Required=false)]
        public List<UpdateTargetListByBatchRequestOperationList> OperationList { get; set; }
        public class UpdateTargetListByBatchRequestOperationList : TeaModel {
            /// <summary>
            /// <para>The ID of the server group.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of server groups.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>11883086</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: the add operation.</description></item>
            /// <item><description><b>del</b>: the remove operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>de393767-6fe1-4a8d-837d-927a2b******</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the VPC-connected instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1ow0rm9t92iza******</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

    }

}
