// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetUmodelDataRequest : TeaModel {
        /// <summary>
        /// <para>Query conditions</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;filter&quot;: {
        ///         &quot;domains&quot;: []
        ///     },
        ///     &quot;offset&quot;: 0,
        ///     &quot;size&quot;: 100000
        /// }</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public object Content { get; set; }

        /// <summary>
        /// <para>Method</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListData</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

    }

}
