// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetGWSInstanceUserRequest : TeaModel {
        /// <summary>
        /// The ID of the visualization instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("UserUid")]
        [Validation(Required=false)]
        public string UserUid { get; set; }

    }

}
