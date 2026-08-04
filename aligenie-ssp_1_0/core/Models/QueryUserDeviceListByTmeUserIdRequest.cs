// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class QueryUserDeviceListByTmeUserIdRequest : TeaModel {
        /// <summary>
        /// <para>&quot;KG&quot;: KuGou<br>&quot;KW&quot;: Kuwo<br>&quot;QM&quot;: QQ Music</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("Sp")]
        [Validation(Required=false)]
        public string Sp { get; set; }

        /// <summary>
        /// <para>TME User ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDEEDE337BAA780793D72F7F20BEF2F5</para>
        /// </summary>
        [NameInMap("TmeUserId")]
        [Validation(Required=false)]
        public string TmeUserId { get; set; }

    }

}
