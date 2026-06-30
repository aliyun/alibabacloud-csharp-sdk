// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateQualityCheckSchemeRequest : TeaModel {
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
        /// <para>JSON request body. For details, see the parameter description in the request parameters section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataType&quot;:1,&quot;name&quot;:&quot;质检方案A&quot;,&quot;type&quot;:1}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
