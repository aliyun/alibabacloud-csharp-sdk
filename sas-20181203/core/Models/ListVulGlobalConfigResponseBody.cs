// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVulGlobalConfigResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations.
        /// </summary>
        [NameInMap("VulGlobalConfigList")]
        [Validation(Required=false)]
        public List<ListVulGlobalConfigResponseBodyVulGlobalConfigList> VulGlobalConfigList { get; set; }
        public class ListVulGlobalConfigResponseBodyVulGlobalConfigList : TeaModel {
            /// <summary>
            /// The key of the configuration item.
            /// </summary>
            [NameInMap("ConfigKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// The value of the configuration item.
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

        }

    }

}
