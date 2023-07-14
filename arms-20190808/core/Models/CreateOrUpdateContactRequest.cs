// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact.
        /// 
        /// *   If you do not specify this parameter, a new alert contact is created.
        /// *   If you specify this parameter, the specified alert contact is modified.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// The name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The webhook URL of the DingTalk chatbot.
        /// </summary>
        [NameInMap("DingRobotUrl")]
        [Validation(Required=false)]
        public string DingRobotUrl { get; set; }

        /// <summary>
        /// The email address of the alert contact.
        /// 
        /// > You must specify at least one of the **Phone** and **Email** parameters. Each mobile number or email address can be used for only one alert contact.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// Specifies whether the email address is verified.
        /// </summary>
        [NameInMap("IsEmailVerify")]
        [Validation(Required=false)]
        public bool? IsEmailVerify { get; set; }

        /// <summary>
        /// The mobile number of the alert contact.
        /// 
        /// > You must specify at least one of the **Phone** and **Email** parameters. Each mobile number or email address can be used for only one alert contact.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The operation that you want to perform if phone calls fail to be answered. Valid values:
        /// 
        /// *   0: No operation is performed.
        /// *   1: A phone call is made again.
        /// *   2: A text message is sent.
        /// *   3 (default value): The global default value is used.
        /// </summary>
        [NameInMap("ReissueSendNotice")]
        [Validation(Required=false)]
        public long? ReissueSendNotice { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
