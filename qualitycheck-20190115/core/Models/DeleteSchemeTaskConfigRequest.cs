// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class DeleteSchemeTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>A JSON object that contains the request parameters. For more information, see the parameter details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:&quot;329&quot;}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
