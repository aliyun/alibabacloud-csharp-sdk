// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class ListSynonymsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoAuth</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;data&quot;: {
        ///     &quot;data&quot;: [
        ///       {
        ///         &quot;gmtModified&quot;: 1734401404000,
        ///         &quot;columns&quot;: [
        ///           &quot;test.id&quot;,
        ///           &quot;user_info.createdt&quot;
        ///         ],
        ///         &quot;synonymIdKey&quot;: &quot;synonyms-AAAAAAAAAVLaD8z63NnFhA&quot;,
        ///         &quot;wordSynonyms&quot;: [
        ///           &quot;1&quot;
        ///         ],
        ///         &quot;workSpaceId&quot;: &quot;10024809&quot;,
        ///         &quot;gmtCreate&quot;: 1734401404000,
        ///         &quot;word&quot;: &quot;1&quot;,
        ///         &quot;status&quot;: 1
        ///       }
        ///     ],
        ///     &quot;nextToken&quot;: &quot;k1BLjEN114wyfrhDHoJlbg==&quot;,
        ///     &quot;totalCount&quot;: 0
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NoAuth</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D02D895A-5E58-5A9F-963D-D8B027AB7AE2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
