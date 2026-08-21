// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260810.Models
{
    public class A2aRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a2a</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>791</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message/stream</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;message&quot;: {
        ///       &quot;role&quot;: &quot;user&quot;,
        ///       &quot;parts&quot;: [
        ///         {
        ///           &quot;kind&quot;: &quot;text&quot;,
        ///           &quot;text&quot;: &quot;你好“
        ///         }
        ///       ]
        ///       &quot;kind&quot;: &quot;message&quot;
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

    }

}
