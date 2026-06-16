// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessPathsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network endpoint access paths.</para>
        /// </summary>
        [NameInMap("NetworkAccessPaths")]
        [Validation(Required=false)]
        public List<ListNetworkAccessPathsResponseBodyNetworkAccessPaths> NetworkAccessPaths { get; set; }
        public class ListNetworkAccessPathsResponseBodyNetworkAccessPaths : TeaModel {
            /// <summary>
            /// <para>The time when the dedicated network endpoint access path was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <para>The ID of the dedicated network endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated network endpoint access path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nap_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessPathId")]
            [Validation(Required=false)]
            public string NetworkAccessPathId { get; set; }

            /// <summary>
            /// <para>The ID of the ENI that is used by the dedicated network endpoint access path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-examplexxx</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The private IP address of the ENI that is used by the dedicated network endpoint access path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The status of the dedicated network endpoint access path. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>pending: The path is being initialized.</para>
            /// </description></item>
            /// <item><description><para>creating: The path is being created.</para>
            /// </description></item>
            /// <item><description><para>running: The path is running.</para>
            /// </description></item>
            /// <item><description><para>deleting: The path is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the dedicated network endpoint access path was last updated. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ENI of the dedicated network endpoint access path belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-examplexxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
