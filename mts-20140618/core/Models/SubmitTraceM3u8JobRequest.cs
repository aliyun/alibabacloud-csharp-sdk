// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
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
        /// <b>Example:</b>
        /// <para>437bd2b516ffda105d07b12a9a82****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;exampleBucket&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;out.m3u8&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

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

    }

}
