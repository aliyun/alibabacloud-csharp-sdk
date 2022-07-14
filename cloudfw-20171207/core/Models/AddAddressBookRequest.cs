/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookRequest : TeaModel {
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        [NameInMap("AutoAddTagEcs")]
        [Validation(Required=false)]
        public string AutoAddTagEcs { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestTagList> TagList { get; set; }
        public class AddAddressBookRequestTagList : TeaModel {
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

}
