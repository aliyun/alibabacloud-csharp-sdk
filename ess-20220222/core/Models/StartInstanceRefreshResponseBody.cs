// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class StartInstanceRefreshResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ir-a12ds234fasd*****</para>
        /// </summary>
        [NameInMap("InstanceRefreshTaskId")]
        [Validation(Required=false)]
        public string InstanceRefreshTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
