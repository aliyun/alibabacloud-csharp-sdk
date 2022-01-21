// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListResponseBodyContactsContact : TeaModel {
                public DescribeContactListResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannels : TeaModel {
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
                public DescribeContactListResponseBodyContactsContactChannelsState ChannelsState { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannelsState : TeaModel {
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
                public DescribeContactListResponseBodyContactsContactContactGroups ContactGroups { get; set; }
                public class DescribeContactListResponseBodyContactsContactContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }
                public long? CreateTime { get; set; }
                public string Desc { get; set; }
                public string Lang { get; set; }
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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
