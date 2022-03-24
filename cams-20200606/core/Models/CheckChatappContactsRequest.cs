/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CheckChatappContactsRequest : TeaModel {
        /// <summary>
        /// 通道类型
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 需要查询的用户列表，JSON格式，单次调用最多查询10个。注意：用户号码必须加国家码
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public string Contacts { get; set; }

        /// <summary>
        /// 发送号码
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
