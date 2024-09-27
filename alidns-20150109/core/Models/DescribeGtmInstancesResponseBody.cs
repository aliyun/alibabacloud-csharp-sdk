// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of queried instances.</para>
        /// </summary>
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public DescribeGtmInstancesResponseBodyGtmInstances GtmInstances { get; set; }
        public class DescribeGtmInstancesResponseBodyGtmInstances : TeaModel {
            [NameInMap("GtmInstance")]
            [Validation(Required=false)]
            public List<DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance> GtmInstance { get; set; }
            public class DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance : TeaModel {
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
                /// <para>The name of the alert group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\\&quot;R\&amp;D group\\&quot;]</para>
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                /// <summary>
                /// <para>The CNAME domain name that is used to access the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance1.14.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The CNAME domain name used to access the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SYSTEM_ASSIGN</b>: A CNAME domain name assigned by the system is used.</description></item>
                /// <item><description><b>CUSTOM</b>: A custom CNAME domain name is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_ASSIGN</para>
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
                /// <para>The UNIX timestamp that indicates when the instance was created.</para>
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
                /// <para>The UNIX timestamp that indicates when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1528284856000</para>
                /// </summary>
                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance1</para>
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
                /// <para>The load balancing policy that is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL_RR</b>: Load balancing</description></item>
                /// <item><description><b>RATIO</b>: Weighted round-robin</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RATIO</para>
                /// </summary>
                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfm2q2jqpjh***</para>
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
                /// <para>The domain name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

                /// <summary>
                /// <para>The version code of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>biaozhun</para>
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193B0163-7F93-42DF-AB05-ACEEB7D22707</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
