// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FileSmartCluster : TeaModel {
        /// <summary>
        /// <para>Similarity</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("Similarity")]
        [Validation(Required=false)]
        public float? Similarity { get; set; }

        /// <summary>
        /// <para>SmartClusterId</para>
        /// 
        /// <b>Example:</b>
        /// <para>SmartCluster-12cd1645-deae-4b5e-9434-613747b75f6d</para>
        /// </summary>
        [NameInMap("SmartClusterId")]
        [Validation(Required=false)]
        public string SmartClusterId { get; set; }

    }

}
