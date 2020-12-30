// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class UpdateUserInfoRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public long? UserGroupId { get; set; }

        [NameInMap("Birthday")]
        [Validation(Required=false)]
        public long? Birthday { get; set; }

        [NameInMap("ImageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Sex")]
        [Validation(Required=false)]
        public int? Sex { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        [NameInMap("CertificateNo")]
        [Validation(Required=false)]
        public string CertificateNo { get; set; }

        [NameInMap("PhoneNo")]
        [Validation(Required=false)]
        public string PhoneNo { get; set; }

        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("OverwriteImg")]
        [Validation(Required=false)]
        public bool? OverwriteImg { get; set; }

    }

}
