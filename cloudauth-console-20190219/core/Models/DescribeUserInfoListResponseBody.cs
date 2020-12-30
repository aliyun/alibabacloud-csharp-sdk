// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class DescribeUserInfoListResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInfoList")]
        [Validation(Required=false)]
        public List<DescribeUserInfoListResponseBodyUserInfoList> UserInfoList { get; set; }
        public class DescribeUserInfoListResponseBodyUserInfoList : TeaModel {
            [NameInMap("Sex")]
            [Validation(Required=false)]
            public int? Sex { get; set; }

            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            [NameInMap("Birthday")]
            [Validation(Required=false)]
            public long? Birthday { get; set; }

            [NameInMap("PhoneNo")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public long? UserGroupId { get; set; }

            [NameInMap("IdentifyingImage")]
            [Validation(Required=false)]
            public string IdentifyingImage { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("CertificateNo")]
            [Validation(Required=false)]
            public string CertificateNo { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
