// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateCheckTypeToSchemeRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Request parameter in JSON format. For details, see the additional information about request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:&quot;187&quot;,&quot;checkName&quot;:&quot;质检维度名&quot;,&quot;sourceScore&quot;:20}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
