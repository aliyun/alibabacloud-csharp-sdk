// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserResourcePackageRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The status of the resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>valid</b>: valid</description></item>
        /// <item><description><b>closed</b>: expired</description></item>
        /// <item><description>If you leave this parameter empty, all resource plans are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
