// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RevertAssignedSessionGroupRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;isSchemeData&quot;:1,&quot;forceRevertSessionGroup&quot;:true,&quot;sessionGroupIdList&quot;:[&quot;1&quot;]}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
