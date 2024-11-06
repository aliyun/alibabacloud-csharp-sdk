// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserRealTimeDeliveryFieldRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cdn_log_access_l1</b>: access logs of L1 Dynamic Content Delivery Network (DCDN) points of presence (POPs)</description></item>
        /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
        /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

    }

}
