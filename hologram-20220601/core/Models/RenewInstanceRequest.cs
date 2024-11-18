// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable monthly auto-renewal. The default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you enable auto-renewal for an instance for which auto-renewal is enabled, an error is reported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The renewal duration. Unit: month.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

    }

}
