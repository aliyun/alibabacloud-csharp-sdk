// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactGroupsResponseBody : TeaModel {
        /// <summary>
        /// The objects that were returned.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactGroupsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactGroupsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The name of the alert contact group.
            /// </summary>
            [NameInMap("AlertContactGroups")]
            [Validation(Required=false)]
            public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroups> AlertContactGroups { get; set; }
            public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroups : TeaModel {
                /// <summary>
                /// The ID of the alert contact group.
                /// </summary>
                [NameInMap("ArmsContactGroupId")]
                [Validation(Required=false)]
                public long? ArmsContactGroupId { get; set; }

                /// <summary>
                /// The ID of the alert contact group.
                /// </summary>
                [NameInMap("ContactGroupId")]
                [Validation(Required=false)]
                public float? ContactGroupId { get; set; }

                /// <summary>
                /// The name of the alert contact group.
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// The contact information. If the **IsDetail** parameter is set to `false`, no **contact** information is displayed.
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts> Contacts { get; set; }
                public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts : TeaModel {
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
                    /// The mobile number of the alert contact.
                    /// </summary>
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alert contact groups displayed on each page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of alert contact groups.
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
