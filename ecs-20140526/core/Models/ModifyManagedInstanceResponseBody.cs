// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyManagedInstanceResponseBody : TeaModel {
        /// <summary>
        /// The name of the managed instance.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public ModifyManagedInstanceResponseBodyInstance Instance { get; set; }
        public class ModifyManagedInstanceResponseBodyInstance : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the managed instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// Details of the managed instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
