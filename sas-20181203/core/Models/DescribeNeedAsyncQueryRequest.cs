// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNeedAsyncQueryRequest : TeaModel {
        /// <summary>
        /// <para>The type of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>suspicious</b>: alerts</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suspicious</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
