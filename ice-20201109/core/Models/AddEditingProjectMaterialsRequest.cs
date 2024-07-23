// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;video&quot;:&quot;<em><b><b>2e057304fcd9b145c5cafc</b></b></em>&quot;, &quot;image&quot;:&quot;<b><b>8021a8d493da643c8acd98</b></b>*,<em><b><b>cb6307a4edea614d8b3f3c</b></b></em>&quot;, &quot;liveStream&quot;: &quot;[{\&quot;appName\&quot;:\&quot;testrecord\&quot;,\&quot;domainName\&quot;:\&quot;test.alivecdn.com\&quot;,\&quot;liveUrl\&quot;:\&quot;rtmp://test.alivecdn.com/testrecord/teststream\&quot;,\&quot;streamName\&quot;:\&quot;teststream\&quot;}]&quot;, &quot;editingProject&quot;: &quot;<em><b><b>9b145c5cafc2e057304fcd</b></b></em>&quot;}</para>
        /// </summary>
        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>b2101cb318c</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
