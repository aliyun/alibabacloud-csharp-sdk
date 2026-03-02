// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorGroupMemberDeleteCmd : TeaModel {
        [NameInMap("contactIds")]
        [Validation(Required=false)]
        public List<long?> ContactIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

    }

}
