// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAlternativeSnapshotReposRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the OSS reference repositories that have already been added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Returns the already added repositories.</description></item>
        /// <item><description>false: Does not return the already added repositories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alreadySetItems")]
        [Validation(Required=false)]
        public bool? AlreadySetItems { get; set; }

    }

}
