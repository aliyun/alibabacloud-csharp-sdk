// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MultimodalSearchBody : TeaModel {
        /// <summary>
        /// <para>Additional query parameters, such as blocked sites</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;excludeSites&quot;: &quot;<a href="http://www.360doc.com,weibo.com">www.360doc.com,weibo.com</a>&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("advancedParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParams { get; set; }

        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>Query content</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
