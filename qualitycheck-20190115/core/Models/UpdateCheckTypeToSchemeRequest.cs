// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateCheckTypeToSchemeRequest : TeaModel {
        /// <summary>
        /// <para>The baseMeAgentId.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Input parameter in JSON format. For more information, see the request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:&quot;187&quot;,&quot;checkName&quot;:&quot;服务规范性检测2&quot;,&quot;sourceScore&quot;:20,&quot;checkType&quot;:0}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
