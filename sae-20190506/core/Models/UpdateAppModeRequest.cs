// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateAppModeRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>Enable Idle Mode?</para>
        /// <para>Enumeration value:</para>
        /// <list type="bullet">
        /// <item><description>true: enables.</description></item>
        /// <item><description>false: disables.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
