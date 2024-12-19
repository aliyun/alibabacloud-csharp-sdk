// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>log</b>: other logs</description></item>
        /// <item><description><b>survey</b>: inspection logs</description></item>
        /// </list>
        /// <para>Enumeration value:</para>
        /// <list type="bullet">
        /// <item><description>PROVIDER</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROVIDER</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logs-gateway</para>
        /// </summary>
        [NameInMap("SlsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ford-api-gateway-log</para>
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

    }

}
