// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSnapshotSettingRequest : TeaModel {
        /// <summary>
        /// <para>The data backup configuration, including the automatic backup start time and the scheduled backup switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;quartzRegex&quot;:&quot;0 0 01 ? * * <em>&quot;,
        ///     &quot;enable&quot;:true,
        ///     &quot;indices&quot;: [
        ///         &quot;orders-</em>&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
