// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsRequest : TeaModel {
        /// <summary>
        /// The ID of the remediation setting. If you want to specify multiple IDs, separate them with commas (,).
        /// 
        /// You can call the [ListRemediations](~~270772~~) operation to obtain the remediation setting ID.
        /// </summary>
        [NameInMap("RemediationIds")]
        [Validation(Required=false)]
        public string RemediationIds { get; set; }

    }

}
