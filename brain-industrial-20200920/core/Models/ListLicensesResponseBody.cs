// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListLicensesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LicenseList")]
        [Validation(Required=false)]
        public List<ListLicensesResponseBodyLicenseList> LicenseList { get; set; }
        public class ListLicensesResponseBodyLicenseList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-14 14:15:45</para>
            /// </summary>
            [NameInMap("ActivateTime")]
            [Validation(Required=false)]
            public string ActivateTime { get; set; }

            [NameInMap("AdaptiveMachine")]
            [Validation(Required=false)]
            public int? AdaptiveMachine { get; set; }

            [NameInMap("AllDuration")]
            [Validation(Required=false)]
            public string AllDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-14 13:17:20</para>
            /// </summary>
            [NameInMap("BuyTime")]
            [Validation(Required=false)]
            public string BuyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-14 14:15:45</para>
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-14 14:15:45</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>451f14ee73604aesdfe4da606764ce09</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aics_1000</para>
            /// </summary>
            [NameInMap("LicenseSpecCode")]
            [Validation(Required=false)]
            public string LicenseSpecCode { get; set; }

            [NameInMap("LicenseSpecName")]
            [Validation(Required=false)]
            public string LicenseSpecName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>brainindustrial_aicsruntime_public_cn</para>
            /// </summary>
            [NameInMap("LicenseSpecType")]
            [Validation(Required=false)]
            public string LicenseSpecType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public int? MemoryLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnActivateAllDuration")]
            [Validation(Required=false)]
            public string UnActivateAllDuration { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FAC892CE-5A94-5616-91DC-629B09CC6792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public string TotalPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPageCount")]
        [Validation(Required=false)]
        public string TotalPageCount { get; set; }

    }

}
