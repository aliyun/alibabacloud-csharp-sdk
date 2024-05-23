// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class QueryInstanceInfoByConnRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
