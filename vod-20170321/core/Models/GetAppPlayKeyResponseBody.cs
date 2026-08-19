// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppPlayKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The application playback key information.</para>
        /// </summary>
        [NameInMap("AppPlayKey")]
        [Validation(Required=false)]
        public GetAppPlayKeyResponseBodyAppPlayKey AppPlayKey { get; set; }
        public class GetAppPlayKeyResponseBodyAppPlayKey : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-1000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the playback key was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-18T03:59:01Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The time when the playback key was last modified. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-18T03:59:01Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The playback key.</para>
            /// <list type="bullet">
            /// <item><description>Only uppercase letters, lowercase letters, and digits are supported. The length must be 8 to 20 characters.</description></item>
            /// <item><description>UTF-8 encoding.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yzNgTUtAl6HAuosIA</para>
            /// </summary>
            [NameInMap("PlayKey")]
            [Validation(Required=false)]
            public string PlayKey { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
