// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAuditLogCollectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of SQL collector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("CollectorStatus")]
        [Validation(Required=false)]
        public string CollectorStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59011D2B-2A38-4207-A86C-72BC1F882D19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
