// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetCustomResourceStatsRequest : TeaModel {
        /// <summary>
        /// <para>The business type. Default value: enterprise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("MainBizType")]
        [Validation(Required=false)]
        public string MainBizType { get; set; }

    }

}
