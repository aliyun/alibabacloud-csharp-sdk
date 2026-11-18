// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedSearchOutput : TeaModel {
        /// <summary>
        /// <para>The consumed credits information.</para>
        /// </summary>
        [NameInMap("costCredits")]
        [Validation(Required=false)]
        public UnifiedCostCredits CostCredits { get; set; }

        /// <summary>
        /// <para>The web page search results.</para>
        /// </summary>
        [NameInMap("pageItems")]
        [Validation(Required=false)]
        public List<UnifiedPageItem> PageItems { get; set; }

        /// <summary>
        /// <para>The search context information.</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public UnifiedQueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>The web page results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35E5608A-A737-2038-****-D9D34C6BFD9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The vertical API scenario-based results.</para>
        /// </summary>
        [NameInMap("sceneItems")]
        [Validation(Required=false)]
        public List<UnifiedSceneItem> SceneItems { get; set; }

        /// <summary>
        /// <para>The basic search information.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public UnifiedSearchInformation SearchInformation { get; set; }

    }

}
