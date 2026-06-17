// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBEndpointAddressRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the new endpoint. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Consist of lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Start with a letter and end with a digit or a letter.</para>
        /// </description></item>
        /// <item><description><para>Be 6 to 40 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pe-**************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the new endpoint. Set the value to <b>Public</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The zone information.</para>
        /// </summary>
        [NameInMap("ZoneInfo")]
        [Validation(Required=false)]
        public List<CreateDBEndpointAddressRequestZoneInfo> ZoneInfo { get; set; }
        public class CreateDBEndpointAddressRequestZoneInfo : TeaModel {
            /// <summary>
            /// <para>The virtual switch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-**********</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
