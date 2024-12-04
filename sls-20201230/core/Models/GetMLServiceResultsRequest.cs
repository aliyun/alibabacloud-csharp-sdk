// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMLServiceResultsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowBuiltin")]
        [Validation(Required=false)]
        public bool? AllowBuiltin { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public MLServiceAnalysisParam Body { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
