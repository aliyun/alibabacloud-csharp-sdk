// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceM3u8JobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://cipher.abc.com">https://cipher.abc.com</a></para>
        /// </summary>
        [NameInMap("KeyUri")]
        [Validation(Required=false)]
        public string KeyUri { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitTraceM3u8JobRequestOutput Output { get; set; }
        public class SubmitTraceM3u8JobRequestOutput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;m3u8Type&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>437bd2b516ffda105d07b12a9a82****</para>
        /// </summary>
        [NameInMap("TraceMediaId")]
        [Validation(Required=false)]
        public string TraceMediaId { get; set; }

    }

}
