// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UuidFilter : TeaModel {
        /// <summary>
        /// <para>The exact match condition for the alert rule UUID. Only the alert rule whose UUID equals the specified value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-e5f6-7890-abcd-ef1234567890</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

        /// <summary>
        /// <para>The set match condition for alert rule UUIDs. All alert rules whose UUIDs are in the specified list are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;,&quot;b2c3d4e5-f6a7-8901-bcde-f12345678901&quot;]</para>
        /// </summary>
        [NameInMap("in")]
        [Validation(Required=false)]
        public List<string> In { get; set; }

    }

}
