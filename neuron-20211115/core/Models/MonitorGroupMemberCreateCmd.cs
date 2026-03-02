// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorGroupMemberCreateCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>121321412341</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("contactIds")]
        [Validation(Required=false)]
        public List<long?> ContactIds { get; set; }

    }

}
