// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLServiceAnalysisParam : TeaModel {
        /// <summary>
        /// <para>The input data.</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Input { get; set; }

        /// <summary>
        /// <para>The parameter.</para>
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameter { get; set; }

    }

}
