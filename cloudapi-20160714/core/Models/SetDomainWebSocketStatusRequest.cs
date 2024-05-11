// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainWebSocketStatusRequest : TeaModel {
        /// <summary>
        /// The action.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionValue")]
        [Validation(Required=false)]
        public string ActionValue { get; set; }

        /// <summary>
        /// The custom domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the API group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("WSSEnable")]
        [Validation(Required=false)]
        public string WSSEnable { get; set; }

    }

}
