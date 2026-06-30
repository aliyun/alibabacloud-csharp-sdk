// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SubmitComplaintRequest : TeaModel {
        /// <summary>
        /// <para>The business space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the complaint details. For more information, see the following table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;taskId&quot;:&quot;ADCA1DE6-8117-472A-B3A1-352A248F90D0&quot;,&quot;fileId&quot;:&quot;653e563d-774f-4f01-a809-cb8bb920c3e6&quot;,&quot;rid&quot;:1346,&quot;comments&quot;:&quot;请重新判定&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
