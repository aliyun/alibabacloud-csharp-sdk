// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Hanas")]
        [Validation(Required=false)]
        public DescribeHanaInstancesResponseBodyHanas Hanas { get; set; }
        public class DescribeHanaInstancesResponseBodyHanas : TeaModel {
            [NameInMap("Hana")]
            [Validation(Required=false)]
            public List<DescribeHanaInstancesResponseBodyHanasHana> Hana { get; set; }
            public class DescribeHanaInstancesResponseBodyHanasHana : TeaModel {
                public string AlertSetting { get; set; }
                public string ClusterId { get; set; }
                public string HanaName { get; set; }
                public string Host { get; set; }
                public int? InstanceNumber { get; set; }
                public string ResourceGroupId { get; set; }
                public long? Status { get; set; }
                public string StatusMessage { get; set; }
                public DescribeHanaInstancesResponseBodyHanasHanaTags Tags { get; set; }
                public class DescribeHanaInstancesResponseBodyHanasHanaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHanaInstancesResponseBodyHanasHanaTagsTag> Tag { get; set; }
                    public class DescribeHanaInstancesResponseBodyHanasHanaTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public bool? UseSsl { get; set; }
                public string UserName { get; set; }
                public bool? ValidateCertificate { get; set; }
                public string VaultId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
