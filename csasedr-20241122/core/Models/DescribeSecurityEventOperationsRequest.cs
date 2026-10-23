// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSecurityEventOperationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security alert event to be handled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61352054</para>
        /// </summary>
        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public long? SecurityEventId { get; set; }

    }

}
