// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class ApplySmallMicroRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("ApplicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        [NameInMap("ApplicantTel")]
        [Validation(Required=false)]
        public string ApplicantTel { get; set; }

        [NameInMap("ApplicantEmail")]
        [Validation(Required=false)]
        public string ApplicantEmail { get; set; }

        [NameInMap("ApplicantPosition")]
        [Validation(Required=false)]
        public string ApplicantPosition { get; set; }

        [NameInMap("DevelopScale")]
        [Validation(Required=false)]
        public string DevelopScale { get; set; }

        [NameInMap("DevelopLanguage")]
        [Validation(Required=false)]
        public string DevelopLanguage { get; set; }

        [NameInMap("BusinessModel")]
        [Validation(Required=false)]
        public string BusinessModel { get; set; }

        [NameInMap("Solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

        [NameInMap("ForHelp")]
        [Validation(Required=false)]
        public string ForHelp { get; set; }

    }

}
