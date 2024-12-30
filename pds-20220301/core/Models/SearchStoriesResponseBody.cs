// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchStoriesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<Story> Items { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJ***</para>
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
