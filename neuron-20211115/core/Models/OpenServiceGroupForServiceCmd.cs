// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class OpenServiceGroupForServiceCmd : TeaModel {
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("laneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<long?> ServiceIds { get; set; }

    }

}
