// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PublishImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The API request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProcessId&quot;: &quot;582d4896-d224-413b-b883-239eeebe0bc5&quot;, &quot;Success&quot;: true}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublishImageResponseBodyData Data { get; set; }
        public class PublishImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The image publishing execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>582d4896-d224-413b-b883-239eeebe0bc5</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was triggered successfully.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
