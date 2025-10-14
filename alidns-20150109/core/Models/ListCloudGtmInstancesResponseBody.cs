// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public ListCloudGtmInstancesResponseBodyInstances Instances { get; set; }
        public class ListCloudGtmInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListCloudGtmInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class ListCloudGtmInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>postpay / prepay</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

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
                /// <para>1231298343343</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>Instance expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Instance expiration time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231298343343</para>
                /// </summary>
                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The ID of the GTM instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gtm-cn-jmp3qnw**03</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance name.</para>
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
                /// <para>50</para>
                /// </summary>
                [NameInMap("MonthlyEmailUsed")]
                [Validation(Required=false)]
                public int? MonthlyEmailUsed { get; set; }

                /// <summary>
                /// <para>SMS quota, only supported on the China site as international sites do not support SMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MonthlySmsQuota")]
                [Validation(Required=false)]
                public int? MonthlySmsQuota { get; set; }

                /// <summary>
                /// <para>Monthly SMS sending volume, only supported by the China site as international sites do not support SMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MonthlySmsUsed")]
                [Validation(Required=false)]
                public int? MonthlySmsUsed { get; set; }

                /// <summary>
                /// <para>Monthly webhook send volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
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
                /// <para>The last time the instance was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The last modification time of the instance (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231298343343</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>GTM instance version:</para>
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
        /// <para>Current page number, starting with <b>1</b>, default is <b>1</b>.</para>
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
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of instance entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
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
