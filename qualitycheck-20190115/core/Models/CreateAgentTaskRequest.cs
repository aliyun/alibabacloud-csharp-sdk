// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete <b>JSON string</b> information. For details, see the following sections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
