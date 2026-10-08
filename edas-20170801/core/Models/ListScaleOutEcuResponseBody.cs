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

        [NameInMap("EcuInfoList")]
        [Validation(Required=false)]
        public ListScaleOutEcuResponseBodyEcuInfoList EcuInfoList { get; set; }
        public class ListScaleOutEcuResponseBodyEcuInfoList : TeaModel {
            [NameInMap("EcuInfo")]
            [Validation(Required=false)]
            public List<ListScaleOutEcuResponseBodyEcuInfoListEcuInfo> EcuInfo { get; set; }
            public class ListScaleOutEcuResponseBodyEcuInfoListEcuInfo : TeaModel {
                [NameInMap("AvailableCpu")]
                [Validation(Required=false)]
                public int? AvailableCpu { get; set; }

                [NameInMap("AvailableMem")]
                [Validation(Required=false)]
                public int? AvailableMem { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DockerEnv")]
                [Validation(Required=false)]
                public bool? DockerEnv { get; set; }

                [NameInMap("EcuId")]
                [Validation(Required=false)]
                public string EcuId { get; set; }

                [NameInMap("HeartbeatTime")]
                [Validation(Required=false)]
                public long? HeartbeatTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IpAddr")]
                [Validation(Required=false)]
                public string IpAddr { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
