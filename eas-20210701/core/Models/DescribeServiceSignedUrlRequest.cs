// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceSignedUrlRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>43200</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Internal")]
        [Validation(Required=false)]
        public bool? Internal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>webview</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
