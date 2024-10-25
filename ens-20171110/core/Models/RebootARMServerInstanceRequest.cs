// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RebootARMServerInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourInstance ID</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
