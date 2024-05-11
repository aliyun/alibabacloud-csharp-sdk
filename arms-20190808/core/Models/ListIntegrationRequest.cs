// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListIntegrationRequest : TeaModel {
        [NameInMap("IntegrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntegrationProductType")]
        [Validation(Required=false)]
        public string IntegrationProductType { get; set; }

        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
