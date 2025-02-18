// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the network resource.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public GetNetworkResponseBodyNetwork Network { get; set; }
        public class GetNetworkResponseBodyNetwork : TeaModel {
            /// <summary>
            /// <para>The time when the network resource was created. The value is a 64-bit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727055811000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the network resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11075500042XXXXX</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the serverless resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2ze13vamugr7jenXXXXX</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The status of the network resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The network resource is waiting to be created.</description></item>
            /// <item><description>Creating: The network resource is being created.</description></item>
            /// <item><description>Running: The network resource is running as expected.</description></item>
            /// <item><description>Deleting: The network resource is being deleted.</description></item>
            /// <item><description>Deleted: The network resource is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
