// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The connection name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

    }

}
