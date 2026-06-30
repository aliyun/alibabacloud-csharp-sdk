// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class DeleteQualityCheckSchemeRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>JSON request body. For details, see the parameter description below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:191}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
