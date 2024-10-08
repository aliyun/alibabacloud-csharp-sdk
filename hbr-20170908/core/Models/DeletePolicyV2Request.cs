// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeletePolicyV2Request : TeaModel {
        /// <summary>
        /// <para>The ID of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************2l6</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
