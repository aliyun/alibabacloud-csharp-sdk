// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The settings of the JVM parameters.
        /// </summary>
        [NameInMap("JvmConfiguration")]
        [Validation(Required=false)]
        public UpdateJvmConfigurationResponseBodyJvmConfiguration JvmConfiguration { get; set; }
        public class UpdateJvmConfigurationResponseBodyJvmConfiguration : TeaModel {
            /// <summary>
            /// The maximum size of the heap memory. Unit: MB.
            /// </summary>
            [NameInMap("MaxHeapSize")]
            [Validation(Required=false)]
            public int? MaxHeapSize { get; set; }

            /// <summary>
            /// The size of the permanent generation heap memory. Unit: MB.
            /// </summary>
            [NameInMap("MaxPermSize")]
            [Validation(Required=false)]
            public int? MaxPermSize { get; set; }

            /// <summary>
            /// The initial size of the heap memory. Unit: MB.
            /// </summary>
            [NameInMap("MinHeapSize")]
            [Validation(Required=false)]
            public int? MinHeapSize { get; set; }

            /// <summary>
            /// The optional parameters.
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
