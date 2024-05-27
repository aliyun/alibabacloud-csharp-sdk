// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTagNameRequest : TeaModel {
        /// <summary>
        /// The name of the tag group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The new name of the tag group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewKey")]
        [Validation(Required=false)]
        public string NewKey { get; set; }

    }

}
