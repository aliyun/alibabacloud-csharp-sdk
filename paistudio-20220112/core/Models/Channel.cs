// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Channel : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("SupportedChannelTypes")]
        [Validation(Required=false)]
        public List<string> SupportedChannelTypes { get; set; }

    }

}
