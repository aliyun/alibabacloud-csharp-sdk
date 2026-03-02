// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class BucUser : TeaModel {
        [NameInMap("account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("empId")]
        [Validation(Required=false)]
        public string EmpId { get; set; }

        [NameInMap("empType")]
        [Validation(Required=false)]
        public string EmpType { get; set; }

        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("personalPhotoUrl")]
        [Validation(Required=false)]
        public string PersonalPhotoUrl { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
