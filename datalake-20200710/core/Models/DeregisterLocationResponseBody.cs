// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class DeregisterLocationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeregisterLocationResponseBodyData Data { get; set; }
        public class DeregisterLocationResponseBodyData : TeaModel {
            /// <summary>
            /// Location ID
            /// </summary>
            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public string LocationId { get; set; }

            [NameInMap("StorageCollectTaskOperationResultList")]
            [Validation(Required=false)]
            public List<StorageCollectTaskOperationResult> StorageCollectTaskOperationResultList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
