// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreatePluginConfigResponseBody : TeaModel {
        /// <summary>
        /// The plug-in configuration ID.
        /// </summary>
        [NameInMap("PluginConfigID")]
        [Validation(Required=false)]
        public long? PluginConfigID { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
