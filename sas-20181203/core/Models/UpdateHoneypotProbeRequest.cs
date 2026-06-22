// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// <para>The ARP check type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Arp")]
        [Validation(Required=false)]
        public bool? Arp { get; set; }

        /// <summary>
        /// <para>The probe name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svwsx-vpc-4430</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ping detection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ping")]
        [Validation(Required=false)]
        public bool? Ping { get; set; }

        /// <summary>
        /// <para>The probe ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListHoneypotProbe~~">ListHoneypotProbe</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbe7e382-956f-473e-beed-bc73a258****</para>
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

        /// <summary>
        /// <para>The list of listening IP addresses.</para>
        /// </summary>
        [NameInMap("ServiceIpList")]
        [Validation(Required=false)]
        public List<string> ServiceIpList { get; set; }

    }

}
