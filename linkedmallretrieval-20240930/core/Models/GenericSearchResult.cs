// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240930.Models
{
    public class GenericSearchResult : TeaModel {
        [NameInMap("pageItems")]
        [Validation(Required=false)]
        public List<ScorePageItem> PageItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public SearchInformation SearchInformation { get; set; }

        [NameInMap("weiboItems")]
        [Validation(Required=false)]
        public List<WeiboItem> WeiboItems { get; set; }

    }

}
