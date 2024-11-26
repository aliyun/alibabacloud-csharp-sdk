// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiVersionInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-version</para>
        /// </summary>
        [NameInMap("headerName")]
        [Validation(Required=false)]
        public string HeaderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myVersion</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Query</para>
        /// </summary>
        [NameInMap("scheme")]
        [Validation(Required=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
