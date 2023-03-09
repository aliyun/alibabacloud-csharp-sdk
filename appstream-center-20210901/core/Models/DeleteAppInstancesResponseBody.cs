// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteAppInstancesResponseBody : TeaModel {
        [NameInMap("DeleteAppInstanceModels")]
        [Validation(Required=false)]
        public List<DeleteAppInstancesResponseBodyDeleteAppInstanceModels> DeleteAppInstanceModels { get; set; }
        public class DeleteAppInstancesResponseBodyDeleteAppInstanceModels : TeaModel {
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
