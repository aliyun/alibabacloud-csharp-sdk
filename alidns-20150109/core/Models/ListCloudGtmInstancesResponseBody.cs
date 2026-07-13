// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmInstancesResponseBody : TeaModel {
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

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("MonitorTaskQuota")]
                [Validation(Required=false)]
                public int? MonitorTaskQuota { get; set; }

                [NameInMap("MonthlyEmailUsed")]
                [Validation(Required=false)]
                public int? MonthlyEmailUsed { get; set; }

                [NameInMap("MonthlySmsQuota")]
                [Validation(Required=false)]
                public int? MonthlySmsQuota { get; set; }

                [NameInMap("MonthlySmsUsed")]
                [Validation(Required=false)]
                public int? MonthlySmsUsed { get; set; }

                [NameInMap("MonthlyWebhookUsed")]
                [Validation(Required=false)]
                public int? MonthlyWebhookUsed { get; set; }

                [NameInMap("ScheduleDomainName")]
                [Validation(Required=false)]
                public string ScheduleDomainName { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
