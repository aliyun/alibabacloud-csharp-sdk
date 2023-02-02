// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceCreateResponseBody : TeaModel {
        /// <summary>
        /// The results that are returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceCreateResponseBodyData Data { get; set; }
        public class OnsInstanceCreateResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the instance that you created.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The edition of the instance. Valid value:
            /// 
            /// *   **1**: Standard Edition
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
