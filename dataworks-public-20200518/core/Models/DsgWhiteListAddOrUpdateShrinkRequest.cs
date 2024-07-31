// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// A collection of whitelists.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public string WhiteListsShrink { get; set; }

    }

}
