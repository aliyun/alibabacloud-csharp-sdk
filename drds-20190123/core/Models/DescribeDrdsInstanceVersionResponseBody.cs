// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceVersionResponseBody : TeaModel {
        /// <summary>
        /// The details about the instance version.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceVersionResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceVersionResponseBodyData : TeaModel {
            /// <summary>
            /// The current version of the instance.
            /// </summary>
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }

            /// <summary>
            /// The latest version of the instance.
            /// </summary>
            [NameInMap("NewestVersion")]
            [Validation(Required=false)]
            public string NewestVersion { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
