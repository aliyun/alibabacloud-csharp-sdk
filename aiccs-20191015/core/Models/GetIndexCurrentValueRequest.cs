// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetIndexCurrentValueRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2332****,2334****</para>
        /// </summary>
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2323****,2324****</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
