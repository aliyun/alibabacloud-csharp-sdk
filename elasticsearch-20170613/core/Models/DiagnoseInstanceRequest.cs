// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceRequest : TeaModel {
        /// <summary>
        /// The timestamp when the diagnostic report was generated.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("diagnoseItems")]
        [Validation(Required=false)]
        public List<string> DiagnoseItems { get; set; }

        [NameInMap("indices")]
        [Validation(Required=false)]
        public List<string> Indices { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
