// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class AddMosaicsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;x&quot;: 504,&quot;y&quot;: 450,&quot;w&quot;: 256,&quot;h&quot;: 153}]</para>
        /// </summary>
        [NameInMap("MarkPosition")]
        [Validation(Required=false)]
        public string MarkPosition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skjjskjk****</para>
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

    }

}
