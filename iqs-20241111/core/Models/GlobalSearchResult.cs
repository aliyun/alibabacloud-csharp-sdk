// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalSearchResult : TeaModel {
        /// <summary>
        /// <para>The list of web page content.</para>
        /// </summary>
        [NameInMap("pageItems")]
        [Validation(Required=false)]
        public List<GlobalPageItem> PageItems { get; set; }

        /// <summary>
        /// <para>The query context.</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public GlobalQueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scenario-specific vertical API recall results.</para>
        /// </summary>
        [NameInMap("sceneItems")]
        [Validation(Required=false)]
        public List<GlobalSceneItem> SceneItems { get; set; }

        /// <summary>
        /// <para>The search information.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public GlobalSearchInformation SearchInformation { get; set; }

    }

}
