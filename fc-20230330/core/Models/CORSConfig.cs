// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CORSConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowCredentials")]
        [Validation(Required=false)]
        public bool? AllowCredentials { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;Content-Type&quot;, &quot;Authorization&quot;]</para>
        /// </summary>
        [NameInMap("allowHeaders")]
        [Validation(Required=false)]
        public List<string> AllowHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;GET&quot;, &quot;POST&quot;, &quot;OPTIONS&quot;]</para>
        /// </summary>
        [NameInMap("allowMethods")]
        [Validation(Required=false)]
        public List<string> AllowMethods { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://example.com">https://example.com</a>&quot;, &quot;<a href="https://app.example.com%22%5D">https://app.example.com&quot;]</a></para>
        /// </summary>
        [NameInMap("allowOrigins")]
        [Validation(Required=false)]
        public List<string> AllowOrigins { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;X-Custom-Header&quot;]</para>
        /// </summary>
        [NameInMap("exposeHeaders")]
        [Validation(Required=false)]
        public List<string> ExposeHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("maxAge")]
        [Validation(Required=false)]
        public int? MaxAge { get; set; }

    }

}
