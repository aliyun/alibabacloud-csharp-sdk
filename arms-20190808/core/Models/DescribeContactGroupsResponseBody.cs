// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactGroupsResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactGroupsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactGroupsResponseBodyPageBean : TeaModel {
            [NameInMap("AlertContactGroups")]
            [Validation(Required=false)]
            public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroups> AlertContactGroups { get; set; }
            public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroups : TeaModel {
                [NameInMap("ArmsContactGroupId")]
                [Validation(Required=false)]
                public long? ArmsContactGroupId { get; set; }

                [NameInMap("ContactGroupId")]
                [Validation(Required=false)]
                public float? ContactGroupId { get; set; }

                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts> Contacts { get; set; }
                public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts : TeaModel {
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

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

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
