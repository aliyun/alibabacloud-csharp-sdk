// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Chart : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public Dictionary<string, object> Action { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("display")]
        [Validation(Required=false)]
        public Dictionary<string, object> Display { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public Dictionary<string, object> Search { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
