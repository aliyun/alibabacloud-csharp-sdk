// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListScaleOutEcuResponseBody : TeaModel {
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
        /// <para>The ECUs.</para>
        /// </summary>
        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListScaleOutEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListScaleOutEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuInfo")]
            [Validation(Required=false)]
            public List<ListScaleOutEcuResponseBodyEcuInfoListEcuInfo> EcuInfo { get; set; }
            public class ListScaleOutEcuResponseBodyEcuInfoListEcuInfo : TeaModel {
                /// <summary>
                /// <para>The number of available CPU cores for the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AvailableCpu")]
                [Validation(Required=false)]
                public int? AvailableCpu { get; set; }

                /// <summary>
                /// <para>The size of available memory for the ECU. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("AvailableMem")]
                [Validation(Required=false)]
                public int? AvailableMem { get; set; }

                /// <summary>
                /// <para>The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573281040819</para>
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
                /// <para>false</para>
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
                /// <para>The ID of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zej4i2jdf*********</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The private IP address of the ECU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("IpAddr")]
                [Validation(Required=false)]
                public string IpAddr { get; set; }

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
                /// <para>Indicates whether the ECU is online. If the ECU is online, its corresponding ECS instance is managed in EDAS. Valid values:</para>
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
                /// <para>The ID of the region where the ECU is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the ECU was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573281040827</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the ECU belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1172<b><b>6608</b></b></para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) where the ECU is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zef6ob8**********</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone where the ECU resides.</para>
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
        /// <para>AF860D6C-ACE3-4429-9D54-3BD15A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
