// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The user-defined description of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for readonly business</para>
        /// </summary>
        [NameInMap("DBInstanceEndpointDescription")]
        [Validation(Required=false)]
        public string DBInstanceEndpointDescription { get; set; }

        /// <summary>
        /// <para>The endpoint ID of the instance. You can call the DescribeDBInstanceEndpoints operation to query the endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-****</para>
        /// </summary>
        [NameInMap("DBInstanceEndpointId")]
        [Validation(Required=false)]
        public string DBInstanceEndpointId { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The information about the endpoint.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("NodeItems")]
        [Validation(Required=false)]
        public List<ModifyDBInstanceEndpointRequestNodeItems> NodeItems { get; set; }
        public class ModifyDBInstanceEndpointRequestNodeItems : TeaModel {
            /// <summary>
            /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// <para>You can query the node ID by using the following methods:</para>
            /// <list type="bullet">
            /// <item><description>Log on the ApsaraDB RDS console, go to the instance details page, and then view the ID of the node in the instance topology in the lower part of the instance details page.</description></item>
            /// <item><description>Call the DescribeDBInstanceAttribute operation to query the node ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rn-xxxx-****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The weight of the node. Read requests are distributed based on the weight.</para>
            /// <para>Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
