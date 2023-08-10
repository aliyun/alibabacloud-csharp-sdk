// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class SchemaIndexesSearchFieldsValue : TeaModel {
        [NameInMap("analyzer")]
        [Validation(Required=false)]
        public string Analyzer { get; set; }

        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        [NameInMap("analyzerGeneration")]
        [Validation(Required=false)]
        public string AnalyzerGeneration { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

    }

}
