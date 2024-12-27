// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class HarmonyPayload : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("displayType")]
        [Validation(Required=false)]
        public string DisplayType { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        [NameInMap("harmonyBody")]
        [Validation(Required=false)]
        public HarmonyBody HarmonyBody { get; set; }

    }

}
