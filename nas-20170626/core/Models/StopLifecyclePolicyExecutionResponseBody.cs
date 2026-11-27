// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class StopLifecyclePolicyExecutionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// <para>A request ID is returned regardless of whether the API call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the request.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
