// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The network access endpoints.</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpoints")]
        [Validation(Required=false)]
        public List<ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpoints> NetworkAccessEndpoints { get; set; }
        public class ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpoints : TeaModel {
            /// <summary>
            /// <para>The VPC configurations of the backup network access endpoint.</para>
            /// </summary>
            [NameInMap("BackupVpcEndpoint")]
            [Validation(Required=false)]
            public ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpointsBackupVpcEndpoint BackupVpcEndpoint { get; set; }
            public class ListNetworkAccessEndpointsResponseBodyNetworkAccessEndpointsBackupVpcEndpoint : TeaModel {
                /// <summary>
                /// <para>The private egress IP addresses of the backup network access endpoint.</para>
                /// </summary>
                [NameInMap("BackupEgressPrivateIpAddresses")]
                [Validation(Required=false)]
                public List<string> BackupEgressPrivateIpAddresses { get; set; }

                /// <summary>
                /// <para>The public egress IP addresses of the backup network access endpoint.</para>
                /// </summary>
                [NameInMap("BackupEgressPublicIpAddresses")]
                [Validation(Required=false)]
                public List<string> BackupEgressPublicIpAddresses { get; set; }

                /// <summary>
                /// <para>The ID of the security group for the backup network access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-examplexxx</para>
                /// </summary>
                [NameInMap("BackupSecurityGroupId")]
                [Validation(Required=false)]
                public string BackupSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches for the backup network access endpoint.</para>
                /// </summary>
                [NameInMap("BackupVSwitchIds")]
                [Validation(Required=false)]
                public List<string> BackupVSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC for the backup network access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-examplexxx</para>
                /// </summary>
                [NameInMap("BackupVpcId")]
                [Validation(Required=false)]
                public string BackupVpcId { get; set; }

                /// <summary>
                /// <para>The region of the VPC for the backup network access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BackupVpcRegionId")]
                [Validation(Required=false)]
                public string BackupVpcRegionId { get; set; }

            }

            /// <summary>
            /// <para>The time when the network access endpoint was created. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The name of the network access endpoint, such as the xx business VPC access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC access endpoint for xx service</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointName")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointName { get; set; }

            /// <summary>
            /// <para>The type of the network access endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>shared: shared network access endpoint.</description></item>
            /// <item><description>private: private network access endpoint.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointType")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointType { get; set; }

            /// <summary>
            /// <para>The ID of the security group used by the private network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-examplexxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The status of the network access endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: pending initialization.</description></item>
            /// <item><description>creating: being created.</description></item>
            /// <item><description>running: running.</description></item>
            /// <item><description>deleting: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the network access endpoint was last updated. The time is displayed in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches to which the private network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the private network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-examplexxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The region of the VPC to which the private network access endpoint is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token returned for the current call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
