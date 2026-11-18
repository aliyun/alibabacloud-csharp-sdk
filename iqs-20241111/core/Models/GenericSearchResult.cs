// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GenericSearchResult : TeaModel {
        /// <summary>
        /// <para>The web content list.</para>
        /// </summary>
        [NameInMap("pageItems")]
        [Validation(Required=false)]
        public List<ScorePageItem> PageItems { get; set; }

        /// <summary>
        /// <para>The query context information.</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public QueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scenario-specific query results, such as structured results for time and weather.</para>
        /// </summary>
        [NameInMap("sceneItems")]
        [Validation(Required=false)]
        public List<SceneItem> SceneItems { get; set; }

        /// <summary>
        /// <para>The search information.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public SearchInformation SearchInformation { get; set; }

        /// <summary>
        /// <para>The Weibo list.</para>
        /// </summary>
        [NameInMap("weiboItems")]
        [Validation(Required=false)]
        public List<WeiboItem> WeiboItems { get; set; }

    }

}
