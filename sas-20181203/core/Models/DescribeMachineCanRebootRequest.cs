// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMachineCanRebootRequest : TeaModel {
        /// <summary>
        /// <para>The type of the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cve: Linux software vulnerabilities</description></item>
        /// <item><description>sys: Windows system vulnerabilities</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sys</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b268326-273e-44fc-a0e3-9482435c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
