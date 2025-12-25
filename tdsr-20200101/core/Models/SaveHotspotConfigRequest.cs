// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class SaveHotspotConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{enabledTitleTag: 0, watermarkImg: []}</para>
        /// </summary>
        [NameInMap("ParamTag")]
        [Validation(Required=false)]
        public string ParamTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5dc5c2dd927e45039dadb312384b****</para>
        /// </summary>
        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

    }

}
