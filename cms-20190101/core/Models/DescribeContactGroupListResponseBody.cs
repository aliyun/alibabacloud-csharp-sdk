// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactGroupListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroups ContactGroups { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroups : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<string> ContactGroup { get; set; }
        };

        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroupList ContactGroupList { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroupList : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<DescribeContactGroupListResponseBodyContactGroupListContactGroup> ContactGroup { get; set; }
            public class DescribeContactGroupListResponseBodyContactGroupListContactGroup : TeaModel {
                public string Describe { get; set; }
                public long? UpdateTime { get; set; }
                public long? CreateTime { get; set; }
                public bool? EnabledWeeklyReport { get; set; }
                public string Name { get; set; }
                public bool? EnableSubscribed { get; set; }
                public DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts Contacts { get; set; }
                public class DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }
            }
        };

    }

}
