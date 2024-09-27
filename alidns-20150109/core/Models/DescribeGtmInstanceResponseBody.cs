// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of access policies of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AccessStrategyNum")]
        [Validation(Required=false)]
        public int? AccessStrategyNum { get; set; }

        /// <summary>
        /// <para>The number of address pools of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AddressPoolNum")]
        [Validation(Required=false)]
        public int? AddressPoolNum { get; set; }

        /// <summary>
        /// <para>The alert group of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\\&quot;Daily test - R\&amp;D group\\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The domain name of the GTM instance to which the service domain name is mapped by using a CNAME record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1.14.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>Indicates whether the CNAME is a custom domain name or is assigned by the system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SYSTEM_ASSIGN</b></description></item>
        /// <item><description><b>CUSTOM</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ASSIGN</para>
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// <para>The time when the GTM instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-06-06T11:34Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the GTM instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1528284856000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The time when the GTM instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-06-06T11:34Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the GTM instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1528284856000</para>
        /// </summary>
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The load balancing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_RR</b>: round robin</description></item>
        /// <item><description><b>RATIO</b>: weighted round-robin</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RATIO</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E41AA251-F9BA-48C6-99B2-2B82B26A573A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-testgroupid</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The global time to live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The domain name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("UserDomainName")]
        [Validation(Required=false)]
        public string UserDomainName { get; set; }

        /// <summary>
        /// <para>The version code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biaozhun</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
