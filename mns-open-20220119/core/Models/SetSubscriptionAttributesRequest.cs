// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetSubscriptionAttributesRequest : TeaModel {
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public SetSubscriptionAttributesRequestDlqPolicy DlqPolicy { get; set; }
        public class SetSubscriptionAttributesRequestDlqPolicy : TeaModel {
            [NameInMap("DeadLetterTargetQueue")]
            [Validation(Required=false)]
            public string DeadLetterTargetQueue { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/roleName</para>
        /// </summary>
        [NameInMap("StsRoleArn")]
        [Validation(Required=false)]
        public string StsRoleArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public SetSubscriptionAttributesRequestTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
        public class SetSubscriptionAttributesRequestTenantRateLimitPolicy : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("MaxReceivesPerSecond")]
            [Validation(Required=false)]
            public int? MaxReceivesPerSecond { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
