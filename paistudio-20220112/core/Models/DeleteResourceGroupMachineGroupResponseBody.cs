// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class DeleteResourceGroupMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2D0392B-D749-5C48-A98A-3FAE5C9444A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
