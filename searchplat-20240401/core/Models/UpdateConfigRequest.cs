// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class UpdateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration content.</para>
        /// </summary>
        [NameInMap("configData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ConfigData { get; set; }

        /// <summary>
        /// <para>Specifies whether this is a dry run request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
