// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ReActivateAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the project that is used to store audit logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-c0703599f695f4b8fa1c6492a33af****</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17163CE9-CE4B-1B87-9185-1A1AD7E7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
