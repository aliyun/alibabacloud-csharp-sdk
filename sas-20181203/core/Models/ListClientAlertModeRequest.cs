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
        /// <item><description><b>strict</b>: Strict mode. This mode has a certain risk of false positives. Use this mode during critical event protection periods.</description></item>
        /// <item><description><b>balance</b>: Balanced mode. This mode detects more suspicious risks while reducing false positives.</description></item>
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
