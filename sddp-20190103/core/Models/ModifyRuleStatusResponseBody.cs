// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of sensitive data detection rules whose status failed to be changed. Multiple IDs are separated with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("FailedIds")]
        [Validation(Required=false)]
        public string FailedIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C3AC882-E5A8-4855-BE77-B6837B695EF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
