/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class AddApplicationEmpIdRelationRequest : TeaModel {
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("EmpIds")]
        [Validation(Required=false)]
        public string EmpIds { get; set; }

        [NameInMap("AhasRegionId")]
        [Validation(Required=false)]
        public string AhasRegionId { get; set; }

    }

}
