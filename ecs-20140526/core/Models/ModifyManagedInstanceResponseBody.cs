// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyManagedInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the managed instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public ModifyManagedInstanceResponseBodyInstance Instance { get; set; }
        public class ModifyManagedInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mi-hz01nmcf****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testInstanceName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>Details of the managed instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
