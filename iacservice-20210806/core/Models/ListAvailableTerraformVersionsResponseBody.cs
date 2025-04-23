// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListAvailableTerraformVersionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>b19952f6-1e03-43e3-ac9b-1be20c9ac1a6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("verisonList")]
        [Validation(Required=false)]
        public List<string> VerisonList { get; set; }

    }

}
