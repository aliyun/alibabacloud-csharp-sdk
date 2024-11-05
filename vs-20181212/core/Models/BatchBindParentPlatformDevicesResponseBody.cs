// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchBindParentPlatformDevicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchBindParentPlatformDevicesResponseBodyResults> Results { get; set; }
        public class BatchBindParentPlatformDevicesResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>348*****380-cn-qingdao</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>some error</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>361*****212-cn-qingdao</para>
            /// </summary>
            [NameInMap("ParentPlatformId")]
            [Validation(Required=false)]
            public string ParentPlatformId { get; set; }

        }

    }

}
