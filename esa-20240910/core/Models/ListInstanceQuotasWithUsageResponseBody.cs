// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasWithUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListInstanceQuotasWithUsageResponseBodyQuotas> Quotas { get; set; }
        public class ListInstanceQuotasWithUsageResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>redirect_rules|rule_quota</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public string QuotaValue { get; set; }

            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public List<ListInstanceQuotasWithUsageResponseBodyQuotasSiteUsage> SiteUsage { get; set; }
            public class ListInstanceQuotasWithUsageResponseBodyQuotasSiteUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>34818329392****</para>
                /// </summary>
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public long? SiteId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.top</para>
                /// </summary>
                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SiteUsage")]
                [Validation(Required=false)]
                public string SiteUsage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>85H66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
