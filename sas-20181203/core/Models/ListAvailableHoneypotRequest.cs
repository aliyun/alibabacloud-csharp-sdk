// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAvailableHoneypotRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the management node to which the honeypot is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4341018b-8e01-43f6-b1d2-af29a2a4****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
