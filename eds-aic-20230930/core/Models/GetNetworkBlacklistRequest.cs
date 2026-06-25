// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetNetworkBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The query type. Valid values: IP and Domain. If you do not specify this parameter, information for both types is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
