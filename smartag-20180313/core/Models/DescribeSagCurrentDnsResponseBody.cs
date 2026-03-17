// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagCurrentDnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.XX.XX.5</para>
        /// </summary>
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0937DEA0-AB4B-42F4-9314-07B97D30282B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IP address of the secondary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.XX.XX.114</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public string SlaveDns { get; set; }

    }

}
