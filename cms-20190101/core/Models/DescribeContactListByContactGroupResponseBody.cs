// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListByContactGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListByContactGroupResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListByContactGroupResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListByContactGroupResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListByContactGroupResponseBodyContactsContact : TeaModel {
                public DescribeContactListByContactGroupResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListByContactGroupResponseBodyContactsContactChannels : TeaModel {
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }
                public long? CreateTime { get; set; }
                public string Desc { get; set; }
                public string Name { get; set; }
                public long? UpdateTime { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
