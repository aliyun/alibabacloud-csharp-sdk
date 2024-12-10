// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListResourceGroupMachineGroupsResponseBody : TeaModel {
        [NameInMap("MachineGroups")]
        [Validation(Required=false)]
        public List<MachineGroup> MachineGroups { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7C42CC7-2E85-508A-84F4-923B605FD10F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
