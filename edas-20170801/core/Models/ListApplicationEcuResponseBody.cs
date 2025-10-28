// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationEcuResponseBody : TeaModel {
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
        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListApplicationEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListApplicationEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuEntity")]
            [Validation(Required=false)]
            public List<ListApplicationEcuResponseBodyEcuInfoListEcuEntity> EcuEntity { get; set; }
            public class ListApplicationEcuResponseBodyEcuInfoListEcuEntity : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e809****-43d7-4c6b-8e01-b0d9d1db****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The number of available CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AvailableCpu")]
                [Validation(Required=false)]
                public int? AvailableCpu { get; set; }

                /// <summary>
                /// <para>The size of available memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("AvailableMem")]
                [Validation(Required=false)]
                public int? AvailableMem { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1542692376066</para>
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
                /// <para>0de2ebdb-9490-4fc4-be41***************</para>
                /// </summary>
                [NameInMap("EcuId")]
                [Validation(Required=false)]
                public string EcuId { get; set; }

                /// <summary>
                /// <para>The time when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573281040819</para>
                /// </summary>
                [NameInMap("HeartbeatTime")]
                [Validation(Required=false)]
                public long? HeartbeatTime { get; set; }

                /// <summary>
                /// <para>The ID of the Elastic Compute Service (ECS) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zej4i2jdf*********</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The internal IP address allocated to the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XXX.XXX</para>
                /// </summary>
                [NameInMap("IpAddr")]
                [Validation(Required=false)]
                public string IpAddr { get; set; }

                /// <summary>
                /// <para>The total size of memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The name of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the ECU was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1599803995894</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the ECU belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b><em>common</em></b></b>@aliyun.com</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zef6ob8**********</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
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
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
