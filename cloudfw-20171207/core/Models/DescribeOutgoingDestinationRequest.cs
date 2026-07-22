// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationRequest : TeaModel {
        /// <summary>
        /// <para>The policy coverage status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FullCoverage</para>
        /// </summary>
        [NameInMap("AclCoverage")]
        [Validation(Required=false)]
        public string AclCoverage { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliYun</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.111XXX</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749089441</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect statistics only on traffic that accesses AI services. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAITraffic")]
        [Validation(Required=false)]
        public string IsAITraffic { get; set; }

        /// <summary>
        /// <para>The language type of the received message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.111.53XXX</para>
        /// </summary>
        [NameInMap("PrivateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

        /// <summary>
        /// <para>The public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.96.74.XXX</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>The security policy for Outbound Domain of outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("SecuritySuggest")]
        [Validation(Required=false)]
        public string SecuritySuggest { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InBytes</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The IP address of the access source. (This field is deprecated.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.3.198.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749657600</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tag ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FirstFlow</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
