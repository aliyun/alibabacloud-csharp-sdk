// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class UpdateCustomAuthPermissionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PermitAction")]
        [Validation(Required=false)]
        public string PermitAction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
