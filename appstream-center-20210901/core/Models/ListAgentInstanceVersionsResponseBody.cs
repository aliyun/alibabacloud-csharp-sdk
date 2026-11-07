// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAgentInstanceVersionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<string> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C5A2E8F-9B3D-4E7A-A1C6-2F8D0E5B7A91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
