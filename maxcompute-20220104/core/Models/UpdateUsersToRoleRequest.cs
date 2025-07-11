// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateUsersToRoleRequest : TeaModel {
        /// <summary>
        /// <para>The accounts.</para>
        /// </summary>
        [NameInMap("add")]
        [Validation(Required=false)]
        public List<string> Add { get; set; }

        /// <summary>
        /// <para>The accounts.</para>
        /// </summary>
        [NameInMap("remove")]
        [Validation(Required=false)]
        public List<string> Remove { get; set; }

    }

}
