// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class ListSubscriptionItemGroupDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubscriptionItemGroupDetails")]
        [Validation(Required=false)]
        public List<ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetails> SubscriptionItemGroupDetails { get; set; }
        public class ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetails : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ItemDetails")]
            [Validation(Required=false)]
            public List<ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetails> ItemDetails { get; set; }
            public class ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetails : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetailsContacts> Contacts { get; set; }
                public class ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetailsContacts : TeaModel {
                    [NameInMap("AccountUID")]
                    [Validation(Required=false)]
                    public long? AccountUID { get; set; }

                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public long? ContactId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("IsAccount")]
                    [Validation(Required=false)]
                    public bool? IsAccount { get; set; }

                    [NameInMap("IsObsolete")]
                    [Validation(Required=false)]
                    public bool? IsObsolete { get; set; }

                    [NameInMap("IsVerifiedEmail")]
                    [Validation(Required=false)]
                    public bool? IsVerifiedEmail { get; set; }

                    [NameInMap("IsVerifiedMobile")]
                    [Validation(Required=false)]
                    public bool? IsVerifiedMobile { get; set; }

                    [NameInMap("LastEmailVerificationTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastEmailVerificationTimeStamp { get; set; }

                    [NameInMap("LastMobileVerificationTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastMobileVerificationTimeStamp { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EmailStatus")]
                [Validation(Required=false)]
                public int? EmailStatus { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public int? ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("PmsgStatus")]
                [Validation(Required=false)]
                public int? PmsgStatus { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SmsStatus")]
                [Validation(Required=false)]
                public int? SmsStatus { get; set; }

                [NameInMap("TtsStatus")]
                [Validation(Required=false)]
                public int? TtsStatus { get; set; }

                [NameInMap("WebhookStatus")]
                [Validation(Required=false)]
                public int? WebhookStatus { get; set; }

                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public List<ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetailsWebhooks> Webhooks { get; set; }
                public class ListSubscriptionItemGroupDetailsResponseBodySubscriptionItemGroupDetailsItemDetailsWebhooks : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ServerUrl")]
                    [Validation(Required=false)]
                    public string ServerUrl { get; set; }

                    [NameInMap("WebhookId")]
                    [Validation(Required=false)]
                    public long? WebhookId { get; set; }

                }

            }

            [NameInMap("ItemGroupId")]
            [Validation(Required=false)]
            public int? ItemGroupId { get; set; }

            [NameInMap("ItemGroupName")]
            [Validation(Required=false)]
            public string ItemGroupName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
