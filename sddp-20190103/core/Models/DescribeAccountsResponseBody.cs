// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAccountsResponseBodyItems> Items { get; set; }
        public class DescribeAccountsResponseBodyItems : TeaModel {
            [NameInMap("DataInstance")]
            [Validation(Required=false)]
            public string DataInstance { get; set; }

            [NameInMap("LoginPolicyName")]
            [Validation(Required=false)]
            public string LoginPolicyName { get; set; }

            [NameInMap("AccountTypeId")]
            [Validation(Required=false)]
            public long? AccountTypeId { get; set; }

            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("FirstLevelDepartId")]
            [Validation(Required=false)]
            public long? FirstLevelDepartId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("DeleteStatus")]
            [Validation(Required=false)]
            public string DeleteStatus { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("RoleNames")]
            [Validation(Required=false)]
            public string RoleNames { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("CellphoneNum")]
            [Validation(Required=false)]
            public string CellphoneNum { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("FirstLevelDepartName")]
            [Validation(Required=false)]
            public string FirstLevelDepartName { get; set; }

            [NameInMap("LoginDataTime")]
            [Validation(Required=false)]
            public long? LoginDataTime { get; set; }

            [NameInMap("TelephoneNum")]
            [Validation(Required=false)]
            public string TelephoneNum { get; set; }

            [NameInMap("ActiveStatus")]
            [Validation(Required=false)]
            public string ActiveStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public DescribeAccountsResponseBodyItemsEventCount EventCount { get; set; }
            public class DescribeAccountsResponseBodyItemsEventCount : TeaModel {
                [NameInMap("Total")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyItemsEventCountTotal Total { get; set; }
                public class DescribeAccountsResponseBodyItemsEventCountTotal : TeaModel {
                    [NameInMap("ExcludeCount")]
                    [Validation(Required=false)]
                    public long? ExcludeCount { get; set; }

                    [NameInMap("ConfirmCount")]
                    [Validation(Required=false)]
                    public long? ConfirmCount { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    [NameInMap("UndealCount")]
                    [Validation(Required=false)]
                    public long? UndealCount { get; set; }

                }
            };

        }

    }

}
