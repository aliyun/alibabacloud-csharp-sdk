// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSecurityEventOperationStatusRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the security alert events.</para>
        /// <remarks>
        /// <para>You must specify either TaskId or SecurityEventIds. The API call succeeds only if one of these parameters is specified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<long?> SecurityEventIds { get; set; }

        /// <summary>
        /// <para>The ID of the task that processes the security alert event.</para>
        /// <remarks>
        /// <para>You must specify either TaskId or SecurityEventIds. The API call succeeds only if one of these parameters is specified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12121</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
