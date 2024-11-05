// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchUnbindDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>64DB7F34-11A8-45DC-A421-40ACF446282C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchUnbindDirectoriesResponseBodyResults> Results { get; set; }
        public class BatchUnbindDirectoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>348*****380-cn-qingdao</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>399*****488-cn-qingdao</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>An error occurred while processing your request.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

    }

}
