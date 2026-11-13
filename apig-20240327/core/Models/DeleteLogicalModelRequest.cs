// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DeleteLogicalModelRequest : TeaModel {
        /// <summary>
        /// <para>The expected version number of the object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedRevision")]
        [Validation(Required=false)]
        public long? ExpectedRevision { get; set; }

    }

}
