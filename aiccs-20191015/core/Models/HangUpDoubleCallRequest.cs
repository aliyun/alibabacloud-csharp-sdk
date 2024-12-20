// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HangUpDoubleCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>68255155****</para>
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
