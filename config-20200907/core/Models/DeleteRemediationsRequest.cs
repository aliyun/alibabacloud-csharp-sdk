// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsRequest : TeaModel {
        /// <summary>
        /// The ID of the remediation template. Separate multiple remediation template IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a remediation template, see [ListRemediations](~~270772~~).
        /// </summary>
        [NameInMap("RemediationIds")]
        [Validation(Required=false)]
        public string RemediationIds { get; set; }

    }

}
