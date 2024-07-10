// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListWebApplicationsOutput : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("WebApplicationWithInstanceCount")]
        [Validation(Required=false)]
        public List<WebApplicationWithInstanceCount> WebApplicationWithInstanceCount { get; set; }

    }

}
