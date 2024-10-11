// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ValidateVirtualClusterNameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValidateVirtualClusterNameResponseBodyData Data { get; set; }
        public class ValidateVirtualClusterNameResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Legal")]
            [Validation(Required=false)]
            public string Legal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C039FD4D-2F3C-4556-AF09-864D3A6485B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
