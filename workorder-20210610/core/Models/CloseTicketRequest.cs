// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class CloseTicketRequest : TeaModel {
        /// <summary>
        /// <para>Work Order Number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>G2BKRWG</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account. You can view your UID in the profile picture in the upper-right corner of the DMS console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1139477549527134</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
