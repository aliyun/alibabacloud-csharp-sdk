// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The destination category ID. In addition to All, RiskDomain, AliYun, and NotAliYun, the NotAliYun category also includes subcategories such as TrustedDomain, AliPay, DingDing, WeChat, Google, Alibaba, CDN, NAT, and TrustIP. More than 25 category values are supported. Use the categories returned by the API as the reference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The destination type. This parameter is required. If this parameter is not specified, ErrorDstType is returned. The value is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Domain: domain name.</description></item>
        /// <item><description>DstIP: destination IP address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Domain</para>
        /// </summary>
        [NameInMap("DstType")]
        [Validation(Required=false)]
        public string DstType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750818370</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language type of the response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.82.45.XXX</para>
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
        /// <para>The fixed category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TypeId")]
        [Validation(Required=false)]
        public string TypeId { get; set; }

    }

}
