// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListNetworkAccessPathsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network access endpoint access paths.</para>
        /// </summary>
        [NameInMap("NetworkAccessPaths")]
        [Validation(Required=false)]
        public List<ListNetworkAccessPathsResponseBodyNetworkAccessPaths> NetworkAccessPaths { get; set; }
        public class ListNetworkAccessPathsResponseBodyNetworkAccessPaths : TeaModel {
            /// <summary>
            /// <para>The time when the dedicated network access endpoint access path was created, in UNIX timestamp format. Unit: milliseconds.</para>
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
            /// <para>The dedicated network access endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated network access endpoint access path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nap_examplexxx</para>
            /// </summary>
            [NameInMap("NetworkAccessPathId")]
            [Validation(Required=false)]
            public string NetworkAccessPathId { get; set; }

            /// <summary>
            /// <para>The ENI ID used by the dedicated network access endpoint access path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-examplexxx</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The private endpoint of the ENI used by the dedicated network access endpoint access path on the private network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The status of the dedicated network access endpoint access path. Valid values:</para>
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
            /// <para>The time when the dedicated network access endpoint access path was last updated, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vSwitch ID to which the ENI of the dedicated network access endpoint access path belongs.</para>
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
