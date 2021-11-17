// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetInstanceUrlResponseBody : TeaModel {
        /// <summary>
        /// webide的链接
        /// </summary>
        [NameInMap("Ide")]
        [Validation(Required=false)]
        public string Ide { get; set; }

        /// <summary>
        /// jupyterlab的链接
        /// </summary>
        [NameInMap("Lab")]
        [Validation(Required=false)]
        public string Lab { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// terminal终端的链接
        /// </summary>
        [NameInMap("Terminal")]
        [Validation(Required=false)]
        public string Terminal { get; set; }

    }

}
