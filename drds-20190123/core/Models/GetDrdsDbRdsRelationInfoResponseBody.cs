// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class GetDrdsDbRdsRelationInfoResponseBody : TeaModel {
        /// <summary>
        /// The structure information about the storage instances of the DRDS database. Each entry corresponds to a primary storage instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDrdsDbRdsRelationInfoResponseBodyData> Data { get; set; }
        public class GetDrdsDbRdsRelationInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the storage instance.
            /// </summary>
            [NameInMap("RdsInstanceId")]
            [Validation(Required=false)]
            public string RdsInstanceId { get; set; }

            /// <summary>
            /// The IDs of the read-only storage instances.
            /// </summary>
            [NameInMap("ReadOnlyInstanceInfo")]
            [Validation(Required=false)]
            public List<string> ReadOnlyInstanceInfo { get; set; }

            /// <summary>
            /// The ID of the storage instance that is in use. If the specified instance in the request is a primary DRDS instance, the value of this parameter is the ID of the primary storage instance. If the specified instance in the request is a read-only DRDS instance, the value of this parameter is the ID of the secondary storage instance.
            /// </summary>
            [NameInMap("UsedInstanceId")]
            [Validation(Required=false)]
            public string UsedInstanceId { get; set; }

            /// <summary>
            /// The type of the storage instance that is in use.
            /// </summary>
            [NameInMap("UsedInstanceType")]
            [Validation(Required=false)]
            public string UsedInstanceType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
