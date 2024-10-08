// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DisableCustomScenePolicyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

    }

}
