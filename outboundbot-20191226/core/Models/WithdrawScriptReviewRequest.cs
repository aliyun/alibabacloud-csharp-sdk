// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class WithdrawScriptReviewRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38d2e8ed-04e9-4dac-83b5-a8e57642ef13</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4e2a770-b97b-465a-80d8-06dca008c503</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
