// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EcsEntityList")]
        [Validation(Required=false)]
        public ListEcsNotInClusterResponseBodyEcsEntityList EcsEntityList { get; set; }
        public class ListEcsNotInClusterResponseBodyEcsEntityList : TeaModel {
            [NameInMap("EcsEntity")]
            [Validation(Required=false)]
            public List<ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity> EcsEntity { get; set; }
            public class ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

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
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
