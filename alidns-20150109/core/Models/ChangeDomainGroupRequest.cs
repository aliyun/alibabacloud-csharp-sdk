// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainGroupRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the destination domain name group.
        /// 
        /// *   If you do not specify GroupId, the domain name is moved to the default group.
        /// *   If you set GroupId to an empty string, the domain name is moved to the default group.
        /// *   If you set GroupId to defaultGroup, the domain name is moved to the default group.
        /// *   If you do not set GroupId to one of the preceding values and set GroupId to an existing group ID, the domain name is moved to the existing group. If you set GroupId to a group ID that does not exist, the domain name remains in the original group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
