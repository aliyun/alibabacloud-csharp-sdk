// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BindNlbRequest : TeaModel {
        /// <summary>
        /// <para>The type of the IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: public endpoint.</description></item>
        /// <item><description>Intranet: private endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the application to which the NLB instance is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The listener that you want to manage. The value is a string that consists of JSON arrays. Each listener contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port number of the NLB listener. This field is required. Data type: integer. Valid values: 0 to 65535.</description></item>
        /// <item><description><b>TargetPort</b>: the port number of the container listener. This field is required. Data type: integer. Valid values: 0 to 65535.</description></item>
        /// <item><description><b>Protocol</b>: the listener protocol. This field is required. Data type: string. Valid values: TCP, UDP, and TCPSSL.</description></item>
        /// <item><description><b>CertIds</b>: the IDs of the server certificates. This field is optional. Data type: string. This field is supported only by TCPSSL listeners.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

        /// <summary>
        /// <para>The ID of the NLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-7z7jjbzz44d82c9***</para>
        /// </summary>
        [NameInMap("NlbId")]
        [Validation(Required=false)]
        public string NlbId { get; set; }

        /// <summary>
        /// <para>The mappings between zones and vSwitches. The value is a JSON string. You can specify at most 10 zones. If the region supports two or more zones, specify at least two zones. A ZoneMapping contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>The ID of the vSwitch in the zone. Each zone can contain only one vSwitch and one subnet. Data type: string.</description></item>
        /// <item><description>The zone ID of the NLB instance. Data type: string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-sersdf****
        /// cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public string ZoneMappings { get; set; }

    }

}
