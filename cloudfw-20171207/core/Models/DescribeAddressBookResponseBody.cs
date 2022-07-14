// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookResponseBody : TeaModel {
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<DescribeAddressBookResponseBodyAcls> Acls { get; set; }
        public class DescribeAddressBookResponseBodyAcls : TeaModel {
            [NameInMap("AddressList")]
            [Validation(Required=false)]
            public List<string> AddressList { get; set; }

            [NameInMap("AddressListCount")]
            [Validation(Required=false)]
            public int? AddressListCount { get; set; }

            [NameInMap("AutoAddTagEcs")]
            [Validation(Required=false)]
            public int? AutoAddTagEcs { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("GroupUuid")]
            [Validation(Required=false)]
            public string GroupUuid { get; set; }

            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsTagList> TagList { get; set; }
            public class DescribeAddressBookResponseBodyAclsTagList : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("TagRelation")]
            [Validation(Required=false)]
            public string TagRelation { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
