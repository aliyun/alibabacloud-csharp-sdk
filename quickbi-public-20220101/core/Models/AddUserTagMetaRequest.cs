// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserTagMetaRequest : TeaModel {
        [NameInMap("TagDescription")]
        [Validation(Required=false)]
        public string TagDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
