// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceRequest : TeaModel {
        /// <summary>
        /// 5A2CFF0E-5718-45B5-9D4D-70B3FF\*\*\*\*
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
        /// en
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
