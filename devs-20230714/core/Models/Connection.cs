// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class Connection : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resourceVersion")]
        [Validation(Required=false)]
        public int? ResourceVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public ConnectionSpec Spec { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public ConnectionStatus Status { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
