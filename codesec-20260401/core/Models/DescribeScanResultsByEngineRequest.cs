// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeScanResultsByEngineRequest : TeaModel {
        /// <summary>
        /// <para>按 baseline_state 过滤 findings。值为 new/unchanged/absent/updated 之一。</para>
        /// </summary>
        [NameInMap("baselineState")]
        [Validation(Required=false)]
        public string BaselineState { get; set; }

        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("packageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

    }

}
