// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreatePluginAttachmentResponseBodyData Data { get; set; }
        public class CreatePluginAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-cvs7jpmm1hkgihaqv4a0</para>
            /// </summary>
            [NameInMap("pluginAttachmentId")]
            [Validation(Required=false)]
            public string PluginAttachmentId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBCB8485-24F9-54CD-B258-CB15FDB27677</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
