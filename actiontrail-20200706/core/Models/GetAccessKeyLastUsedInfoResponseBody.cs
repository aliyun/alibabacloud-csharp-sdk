// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedInfoResponseBody : TeaModel {
        /// <summary>
        /// The AccessKey ID.
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The type of the account to which the AccessKey pair belongs.
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The details about the event.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// The ID of the account to which the AccessKey pair belongs.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Alibaba Cloud service that was last accessed.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The Chinese name of the Alibaba Cloud service that was last accessed.
        /// </summary>
        [NameInMap("ServiceNameCn")]
        [Validation(Required=false)]
        public string ServiceNameCn { get; set; }

        /// <summary>
        /// The English name of the Alibaba Cloud service that was last accessed.
        /// </summary>
        [NameInMap("ServiceNameEn")]
        [Validation(Required=false)]
        public string ServiceNameEn { get; set; }

        /// <summary>
        /// The event source.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The timestamp when the AccessKey pair was last called.
        /// </summary>
        [NameInMap("UsedTimestamp")]
        [Validation(Required=false)]
        public long? UsedTimestamp { get; set; }

        /// <summary>
        /// The name of the account to which the AccessKey pair belongs.
        /// 
        /// If the value of the AccountType parameter is root-account, the value of the UserName parameter is root. If the value of the AccountType parameter is ram-user, the value of the UserName parameter is the name of a RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
