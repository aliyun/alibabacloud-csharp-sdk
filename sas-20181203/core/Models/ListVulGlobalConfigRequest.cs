// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVulGlobalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The key of the configuration item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vul_scan_ip_list</b>: The IP addresses that are detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vul_scan_ip_list</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

    }

}
