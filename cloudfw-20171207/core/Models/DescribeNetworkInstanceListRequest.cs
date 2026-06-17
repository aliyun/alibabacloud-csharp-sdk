// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-x5jayxou71ad73****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The type of connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>expressconnect</para>
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
