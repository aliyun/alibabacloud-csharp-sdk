// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class GetTaskStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Statistics Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPERATORCELL: Operation cell.</description></item>
        /// <item><description>ITEM: Single item.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ITEM</para>
        /// </summary>
        [NameInMap("StatType")]
        [Validation(Required=false)]
        public string StatType { get; set; }

    }

}
