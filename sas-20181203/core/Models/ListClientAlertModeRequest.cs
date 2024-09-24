// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClientAlertModeRequest : TeaModel {
        /// <summary>
        /// <para>The protection mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>strict</b>: The strict mode. False positives may be generated. We recommend that you enable this mode during major events.</description></item>
        /// <item><description><b>balance</b>: The balanced mode. More risks can be detected with less false positives in this mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>strict</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
