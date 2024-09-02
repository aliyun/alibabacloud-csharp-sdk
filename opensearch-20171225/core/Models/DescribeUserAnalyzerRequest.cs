// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeUserAnalyzerRequest : TeaModel {
        /// <summary>
        /// The Associated information,output properties based on hierarchy.
        /// * **all**: Outputs associated app information
        /// </summary>
        [NameInMap("with")]
        [Validation(Required=false)]
        public string With { get; set; }

    }

}
