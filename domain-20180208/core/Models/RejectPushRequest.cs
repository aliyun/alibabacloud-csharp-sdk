// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class RejectPushRequest : TeaModel {
        /// <summary>
        /// <para>Push编号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>push_20250101_abc123</para>
        /// </summary>
        [NameInMap("PushNo")]
        [Validation(Required=false)]
        public string PushNo { get; set; }

    }

}
