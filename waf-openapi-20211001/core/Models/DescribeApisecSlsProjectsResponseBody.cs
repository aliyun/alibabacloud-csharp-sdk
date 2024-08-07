// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSlsProjectsResponseBody : TeaModel {
        /// <summary>
        /// The names of the projects in Simple Log Service.
        /// </summary>
        [NameInMap("Projects")]
        [Validation(Required=false)]
        public List<string> Projects { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
