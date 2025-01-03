// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListServiceConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codeup</para>
        /// </summary>
        [NameInMap("sericeConnectionType")]
        [Validation(Required=false)]
        public string SericeConnectionType { get; set; }

    }

}
