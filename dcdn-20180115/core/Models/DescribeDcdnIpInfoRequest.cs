// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpInfoRequest : TeaModel {
        /// <summary>
        /// <para>The IP address. You can specify only one IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

    }

}
