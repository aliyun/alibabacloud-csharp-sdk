// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class UpdatePidProjectRequest : TeaModel {
        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("PidProjectName")]
        [Validation(Required=false)]
        public string PidProjectName { get; set; }

        [NameInMap("PidProjectDesc")]
        [Validation(Required=false)]
        public string PidProjectDesc { get; set; }

        [NameInMap("PidOrganisationId")]
        [Validation(Required=true)]
        public string PidOrganisationId { get; set; }

    }

}
