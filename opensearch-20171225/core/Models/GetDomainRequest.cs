// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// The name or ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("appGroupIdentity")]
        [Validation(Required=false)]
        public string AppGroupIdentity { get; set; }

    }

}
