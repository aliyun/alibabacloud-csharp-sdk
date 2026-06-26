// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListViewDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next page of results. If null is returned, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>A list of views.</para>
        /// </summary>
        [NameInMap("viewDetails")]
        [Validation(Required=false)]
        public List<View> ViewDetails { get; set; }

    }

}
