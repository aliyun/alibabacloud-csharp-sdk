// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of access policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AccessStrategyNum")]
        [Validation(Required=false)]
        public int? AccessStrategyNum { get; set; }

        /// <summary>
        /// <para>The number of address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AddressPoolNum")]
        [Validation(Required=false)]
        public int? AddressPoolNum { get; set; }

        /// <summary>
        /// <para>The alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;日常测试-研发组\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The CNAME access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**.dns-example.top</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>The CNAME access mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SYSTEM_ASSIGN</b>: The system assigns a domain name.</para>
        /// </description></item>
        /// <item><description><para><b>CUSTOM</b>: You use a custom domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-06-06T11:34Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was created. This is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1528284856000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-06-06T11:34Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the instance. This is a UNIX timestamp.</para>
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
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The load balancing policy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL_RR</b>: round-robin</para>
        /// </description></item>
        /// <item><description><para><b>RATIO</b>: weighted round-robin</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RATIO</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
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
        /// <para>The global TTL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-example.top</para>
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
