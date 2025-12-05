// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppPlayKeyResponseBody : TeaModel {
        [NameInMap("AppPlayKey")]
        [Validation(Required=false)]
        public GetAppPlayKeyResponseBodyAppPlayKey AppPlayKey { get; set; }
        public class GetAppPlayKeyResponseBodyAppPlayKey : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app-1000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-18T03:59:01Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-18T03:59:01Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yzNgTUtAl6HAuosIA</para>
            /// </summary>
            [NameInMap("PlayKey")]
            [Validation(Required=false)]
            public string PlayKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
