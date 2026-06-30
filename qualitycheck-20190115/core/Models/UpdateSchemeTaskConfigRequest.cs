// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateSchemeTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Input parameter JSON. For details, see the request parameters section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeTaskConfigId&quot;:368,&quot;status&quot;:1,&quot;name&quot;:&quot;检测任务 2022-09-21 16:59:50&quot;}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
