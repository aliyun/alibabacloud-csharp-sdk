// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class SaveHotspotTagRequest : TeaModel {
        [NameInMap("ParamTag")]
        [Validation(Required=false)]
        public string ParamTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2345****</para>
        /// </summary>
        [NameInMap("SubSceneUuid")]
        [Validation(Required=false)]
        public string SubSceneUuid { get; set; }

    }

}
