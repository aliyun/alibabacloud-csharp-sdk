// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateWarningConfigRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Complete JSON string information. See the following details for specific content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ridList&quot;:[15670],&quot;configName&quot;:&quot;投诉预警&quot;,&quot;channels&quot;:[{&quot;type&quot;:1,&quot;url&quot;:&quot;<a href="https://xxx%22%7D%5D%7D">https://xxx&quot;}]}</a></para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
