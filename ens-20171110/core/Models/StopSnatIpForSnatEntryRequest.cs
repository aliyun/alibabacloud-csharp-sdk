// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StopSnatIpForSnatEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SNAT entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-5tfi6f8gds82mjmlofeym****</para>
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// <para>The EIP specified in the SNAT entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>221.178.103.143</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

    }

}
