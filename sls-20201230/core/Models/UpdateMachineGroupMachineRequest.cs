// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMachineGroupMachineRequest : TeaModel {
        /// <summary>
        /// <para>The operation on the machine. Valid values: add and delete. A value of add specifies to add the machine to the machine group. A value of delete specifies to remove the machine from the machine group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The machines to be added or removed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<string> Body { get; set; }

    }

}
