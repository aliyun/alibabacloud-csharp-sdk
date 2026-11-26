// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateCheckTypeToSchemeRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The JSON string of the request parameters. For more information, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schemeId&quot;:&quot;187&quot;,&quot;checkName&quot;:&quot;Service compliance check 2&quot;,&quot;sourceScore&quot;:20,&quot;checkType&quot;:0}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
