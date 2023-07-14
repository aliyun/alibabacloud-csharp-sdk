// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactsResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactsResponseBodyPageBean : TeaModel {
            [NameInMap("AlertContacts")]
            [Validation(Required=false)]
            public List<DescribeContactsResponseBodyPageBeanAlertContacts> AlertContacts { get; set; }
            public class DescribeContactsResponseBodyPageBeanAlertContacts : TeaModel {
                [NameInMap("ArmsContactId")]
                [Validation(Required=false)]
                public long? ArmsContactId { get; set; }

                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public float? ContactId { get; set; }

                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("IsEmailVerify")]
                [Validation(Required=false)]
                public bool? IsEmailVerify { get; set; }

                [NameInMap("IsVerify")]
                [Validation(Required=false)]
                public bool? IsVerify { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("ReissueSendNotice")]
                [Validation(Required=false)]
                public long? ReissueSendNotice { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
