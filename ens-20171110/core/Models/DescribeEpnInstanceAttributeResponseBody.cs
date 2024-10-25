// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the EPN configurations.</para>
        /// </summary>
        [NameInMap("ConfVersions")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyConfVersions> ConfVersions { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyConfVersions : TeaModel {
            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-10-11</para>
            /// </summary>
            [NameInMap("ConfVersion")]
            [Validation(Required=false)]
            public string ConfVersion { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-telecom</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the EPN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-xxxx</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the EPN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-test</para>
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// <para>The information about the instance.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyInstances> Instances { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-telecom-4</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epn-xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epn-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The ISP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cmcc: China Mobile</description></item>
            /// <item><description>unicom: China Unicom</description></item>
            /// <item><description>telecom: China Telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.12</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20.3.XX.XX</para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The networking mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SpeedUp: intelligent acceleration network (Internet)</description></item>
        /// <item><description>Connection: internal network</description></item>
        /// <item><description>SpeedUpAndConnection: intelligent acceleration network and internal network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SpeedUp</para>
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the vSwitch.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<DescribeEpnInstanceAttributeResponseBodyVSwitches> VSwitches { get; set; }
        public class DescribeEpnInstanceAttributeResponseBodyVSwitches : TeaModel {
            /// <summary>
            /// <para>The CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-telecom-4</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-xxxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-test</para>
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

        }

    }

}
