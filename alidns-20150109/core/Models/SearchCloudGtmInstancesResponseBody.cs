// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public SearchCloudGtmInstancesResponseBodyInstances Instances { get; set; }
        public class SearchCloudGtmInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<SearchCloudGtmInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class SearchCloudGtmInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// <para>The commodity code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>dns_gtm_public_cn: commodity code on the China site (aliyun.com)</description></item>
                /// <item><description>dns_gtm_public_intl: commodity code on the international site (alibabacloud.com)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dns_gtm_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>Instance creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Instance creation time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710467214858</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>Instance expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-05T16:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>Instance expiration time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725552000000</para>
                /// </summary>
                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public string ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The ID of the GTM 3.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gtm-cn-wwo3a3hbz**</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Schedule instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Monitor probe task quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MonitorTaskQuota")]
                [Validation(Required=false)]
                public int? MonitorTaskQuota { get; set; }

                /// <summary>
                /// <para>Monthly email sending volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("MonthlyEmailUsed")]
                [Validation(Required=false)]
                public int? MonthlyEmailUsed { get; set; }

                /// <summary>
                /// <para>SMS quota, only supported on the China site. International site does not support SMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("MonthlySmsQuota")]
                [Validation(Required=false)]
                public int? MonthlySmsQuota { get; set; }

                /// <summary>
                /// <para>Monthly SMS sending volume, only supported by the China site as international sites do not support SMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("MonthlySmsUsed")]
                [Validation(Required=false)]
                public int? MonthlySmsUsed { get; set; }

                /// <summary>
                /// <para>Monthly webhook dispatch volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MonthlyWebhookUsed")]
                [Validation(Required=false)]
                public int? MonthlyWebhookUsed { get; set; }

                /// <summary>
                /// <para>The access domain name, which consists of a hostname and a zone or a subzone.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("ScheduleDomainName")]
                [Validation(Required=false)]
                public string ScheduleDomainName { get; set; }

                /// <summary>
                /// <para>The last modified time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The last modified time of the instance (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710467214858</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>Global Traffic Management version 3.0 instance types:</para>
                /// <list type="bullet">
                /// <item><description>standard: Standard Edition</description></item>
                /// <item><description>ultimate: Ultimate Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ultimate</para>
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        /// <summary>
        /// <para>Current page number, starting at <b>1</b>, default is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of instances found from the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
