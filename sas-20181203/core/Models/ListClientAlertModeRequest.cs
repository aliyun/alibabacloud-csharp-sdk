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
        /// <item><description><b>strict</b>: Strict mode. Defense mode has a risk of false positives. Use Defense mode during critical event protection periods.</description></item>
        /// <item><description><b>balance</b>: Balance mode. Defense mode detects more suspicious risks while reducing false positives.</description></item>
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
