// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactsResponseBody : TeaModel {
        /// <summary>
        /// The objects that were returned.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The alert contacts.
            /// </summary>
            [NameInMap("AlertContacts")]
            [Validation(Required=false)]
            public List<DescribeContactsResponseBodyPageBeanAlertContacts> AlertContacts { get; set; }
            public class DescribeContactsResponseBodyPageBeanAlertContacts : TeaModel {
                /// <summary>
                /// The ID of the alert contact.
                /// </summary>
                [NameInMap("ArmsContactId")]
                [Validation(Required=false)]
                public long? ArmsContactId { get; set; }

                /// <summary>
                /// The ID of the alert contact.
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public float? ContactId { get; set; }

                /// <summary>
                /// The name of the alert contact.
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// The email address of the alert contact.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// Indicates whether the email address was verified.
                /// </summary>
                [NameInMap("IsEmailVerify")]
                [Validation(Required=false)]
                public bool? IsEmailVerify { get; set; }

                /// <summary>
                /// Indicates whether the mobile number was verified. Valid values:
                /// 
                /// *   `false`: no
                /// *   `true`: yes
                /// </summary>
                [NameInMap("IsVerify")]
                [Validation(Required=false)]
                public bool? IsVerify { get; set; }

                /// <summary>
                /// The mobile number of the alert contact.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The operation that you want to perform if phone calls fail to be answered. Valid values:
                /// 
                /// *   0: No operation is performed.
                /// *   1: A phone call is made again.
                /// *   2: A text message is sent.
                /// *   3 (default value): The global default value is used.
                /// </summary>
                [NameInMap("ReissueSendNotice")]
                [Validation(Required=false)]
                public long? ReissueSendNotice { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alert contacts returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of alert contacts.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
