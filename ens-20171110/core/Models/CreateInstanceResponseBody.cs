// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// The return code. A value of 0 indicates that the request is successful.
        /// 
        /// >  If you call this operation by using SDKs, the return value is of the integer type. If you call this operation by using common methods or HTTP requests, the return value is of the string type.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The IDs of instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyInstanceIds InstanceIds { get; set; }
        public class CreateInstanceResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
