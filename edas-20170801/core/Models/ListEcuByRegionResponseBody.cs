// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcuByRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about ECUs.</para>
        /// </summary>
        [NameInMap("EcuEntityList")]
        [Validation(Required=false)]
        public ListEcuByRegionResponseBodyEcuEntityList EcuEntityList { get; set; }
        public class ListEcuByRegionResponseBodyEcuEntityList : TeaModel {
            [NameInMap("EcuEntity")]
            [Validation(Required=false)]
            public List<ListEcuByRegionResponseBodyEcuEntityListEcuEntity> EcuEntity { get; set; }
            public class ListEcuByRegionResponseBodyEcuEntityListEcuEntity : TeaModel {
                /// <summary>
                /// <para>The number of available CPU cores for the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AvailableCpu")]
                [Validation(Required=false)]
                public int? AvailableCpu { get; set; }

                /// <summary>
                /// <para>The size of available memory for the ECU. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("AvailableMem")]
                [Validation(Required=false)]
                public int? AvailableMem { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The timestamp when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572539283168</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether Docker is installed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Docker is installed.</description></item>
                /// <item><description>false: Docker is not installed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DockerEnv")]
                [Validation(Required=false)]
                public bool? DockerEnv { get; set; }

                /// <summary>
                /// <para>The unique ID of the ECU. To query the ID, you can run the <c>dmidecode</c> command on the ECS instance that corresponds to the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c96c494c-1b91-4456-bbb3-b5afcd16****</para>
                /// </summary>
                [NameInMap("EcuId")]
                [Validation(Required=false)]
                public string EcuId { get; set; }

                /// <summary>
                /// <para>The timestamp when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572867865221</para>
                /// </summary>
                [NameInMap("HeartbeatTime")]
                [Validation(Required=false)]
                public long? HeartbeatTime { get; set; }

                /// <summary>
                /// <para>The ID of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2ze82h8f4zcn449y****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.xxx.xxx</para>
                /// </summary>
                [NameInMap("IpAddr")]
                [Validation(Required=false)]
                public string IpAddr { get; set; }

                /// <summary>
                /// <para>The total size of memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The name of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>worker-k8s-for</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the ECU is online. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The ECU is online.</description></item>
                /// <item><description>false: The ECU is offline.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the ECU resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The timestamp when the ECU was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572867895575</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas@aliyun-****.com</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) in which the ECU resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zew8mi6gqbo5wf****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the ECU resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
