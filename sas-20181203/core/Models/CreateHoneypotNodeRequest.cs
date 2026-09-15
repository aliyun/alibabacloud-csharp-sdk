// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the honeypot to access the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// <item><description><b>false</b>: Not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowHoneypotAccessInternet")]
        [Validation(Required=false)]
        public bool? AllowHoneypotAccessInternet { get; set; }

        /// <summary>
        /// <para>The number of available probes. This parameter is required. If this parameter is not specified, the API returns InvalidParam (400). The minimum value is 20. If the value is less than 20, the API returns InvalidProbeNum (400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AvailableProbeNum")]
        [Validation(Required=false)]
        public int? AvailableProbeNum { get; set; }

        /// <summary>
        /// <para>The name of the management node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manageNode</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The list of allowed CIDR blocks. This parameter is required. At least one allowed CIDR block must be specified (such as 0.0.0.0/0). If this parameter is not specified, the API returns InvalidParam (400).</para>
        /// </summary>
        [NameInMap("SecurityGroupProbeIpList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupProbeIpList { get; set; }

    }

}
