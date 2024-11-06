// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnRealTimeDeliveryProjectRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cdn_log_access_l1</b>: access logs of Dynamic Content Delivery Network (DCDN) points of presence (POPs)</description></item>
        /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
        /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
        /// <item><description>By default, this parameter is left empty, and all logs are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The domain name. You can specify only one domain name in each request. If this parameter is not specified, all domain names are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Valid values: <b>1</b> to <b>100000</b>. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
