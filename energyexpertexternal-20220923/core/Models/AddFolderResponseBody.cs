// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AddFolderResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public FolderItem Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E38E561C-B996-0E19-8DBC-A218AAE17FBA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
