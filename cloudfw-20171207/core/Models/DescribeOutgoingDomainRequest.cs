// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainRequest : TeaModel {
        /// <summary>
        /// <para>The product category. Default value: empty. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The page number to return in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The source of the traffic statistics. Default value: Internet firewall. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The domain name of the outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656750960</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect statistics only on traffic that accesses AI services. Default value: no. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAITraffic")]
        [Validation(Required=false)]
        public string IsAITraffic { get; set; }

        /// <summary>
        /// <para>The language type of the request message. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort method. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The public IP address of the ECS instance that initiates the outbound connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>The sort order based on the specified field. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>SessionCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656664560</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The intelligence tag ID. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliYun</para>
        /// </summary>
        [NameInMap("TagIdNew")]
        [Validation(Required=false)]
        public string TagIdNew { get; set; }

    }

}
