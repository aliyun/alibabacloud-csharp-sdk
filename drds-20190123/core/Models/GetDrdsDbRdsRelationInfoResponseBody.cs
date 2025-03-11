// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class GetDrdsDbRdsRelationInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The structure information about the storage instances of the DRDS database. Each entry corresponds to a primary storage instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDrdsDbRdsRelationInfoResponseBodyData> Data { get; set; }
        public class GetDrdsDbRdsRelationInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the storage instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp16ad920ndxxxx02</para>
            /// </summary>
            [NameInMap("RdsInstanceId")]
            [Validation(Required=false)]
            public string RdsInstanceId { get; set; }

            /// <summary>
            /// <para>The IDs of the read-only storage instances.</para>
            /// </summary>
            [NameInMap("ReadOnlyInstanceInfo")]
            [Validation(Required=false)]
            public List<string> ReadOnlyInstanceInfo { get; set; }

            /// <summary>
            /// <para>The ID of the storage instance that is in use. If the specified instance in the request is a primary DRDS instance, the value of this parameter is the ID of the primary storage instance. If the specified instance in the request is a read-only DRDS instance, the value of this parameter is the ID of the secondary storage instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1l8xi1dd9xxxxbj</para>
            /// </summary>
            [NameInMap("UsedInstanceId")]
            [Validation(Required=false)]
            public string UsedInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the storage instance that is in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("UsedInstanceType")]
            [Validation(Required=false)]
            public string UsedInstanceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82FD0D9B-9A65-40D3-B1D9-8851B1D4AF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
