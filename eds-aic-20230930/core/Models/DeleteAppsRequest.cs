// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DeleteAppsRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

    }

}
