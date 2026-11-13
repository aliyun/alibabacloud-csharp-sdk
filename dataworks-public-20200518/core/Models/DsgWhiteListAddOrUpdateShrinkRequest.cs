// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist collection.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public string WhiteListsShrink { get; set; }

    }

}
