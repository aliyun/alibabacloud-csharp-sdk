// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckInstanceModuleStatusResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckInstanceModuleStatusResponseBodyModule Module { get; set; }
        public class CheckInstanceModuleStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>模块状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ModuleStatus")]
            [Validation(Required=false)]
            public string ModuleStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
