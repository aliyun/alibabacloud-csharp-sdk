// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListReceivedFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried files.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<File> Items { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eym***</para>
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
