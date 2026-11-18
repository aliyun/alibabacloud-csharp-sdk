// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MultimodalSearchBody : TeaModel {
        /// <summary>
        /// <para>The additional query items, such as blocked sites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;excludeSites&quot;: &quot;<a href="http://www.360doc.com,weibo.com">www.360doc.com,weibo.com</a>&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("advancedParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParams { get; set; }

        /// <summary>
        /// <para>The search engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generic</para>
        /// </summary>
        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The query content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
