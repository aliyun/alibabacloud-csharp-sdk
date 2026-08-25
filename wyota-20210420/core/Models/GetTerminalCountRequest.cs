// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetTerminalCountRequest : TeaModel {
        /// <summary>
        /// <para>The terminal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: hardware terminal.</description></item>
        /// <item><description>2: software terminal.</description></item>
        /// <item><description>3: secure browser plug-in.</description></item>
        /// <item><description>4: GuestOS application.</description></item>
        /// <item><description>5: DingTalk Wuying plug-in.</description></item>
        /// <item><description>6: cloud application component.</description></item>
        /// <item><description>7: Cloud Hub.</description></item>
        /// <item><description>8: H5.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

    }

}
