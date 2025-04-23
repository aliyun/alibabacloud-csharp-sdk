// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListTerraformProviderVersionsResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73588ebb-9d40-4660-a59f-764636ae6034</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("verisonList")]
        [Validation(Required=false)]
        public List<string> VerisonList { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListTerraformProviderVersionsResponseBodyVersions> Versions { get; set; }
        public class ListTerraformProviderVersionsResponseBodyVersions : TeaModel {
            [NameInMap("publishedTime")]
            [Validation(Required=false)]
            public string PublishedTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
