// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetLicenseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLicenseResponseBodyData Data { get; set; }
        public class GetLicenseResponseBodyData : TeaModel {
            [NameInMap("ActivateRecord")]
            [Validation(Required=false)]
            public List<GetLicenseResponseBodyDataActivateRecord> ActivateRecord { get; set; }
            public class GetLicenseResponseBodyDataActivateRecord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-04-29 15:03:12</para>
                /// </summary>
                [NameInMap("ActivateTime")]
                [Validation(Required=false)]
                public string ActivateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-04-29 15:01:15</para>
                /// </summary>
                [NameInMap("BuyTime")]
                [Validation(Required=false)]
                public string BuyTime { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-05-01 00:00:00</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("LicenseCode")]
                [Validation(Required=false)]
                public string LicenseCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1040b91765d14ad1a40ff22589070342</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>代表资源一级ID的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-29 15:03:12</para>
            /// </summary>
            [NameInMap("ActivateTime")]
            [Validation(Required=false)]
            public string ActivateTime { get; set; }

            [NameInMap("AdaptiveMachine")]
            [Validation(Required=false)]
            public string AdaptiveMachine { get; set; }

            [NameInMap("AllDuration")]
            [Validation(Required=false)]
            public string AllDuration { get; set; }

            [NameInMap("ApplicableSpecs")]
            [Validation(Required=false)]
            public string ApplicableSpecs { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-29 15:01:15</para>
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
            /// <para>2024-05-01 00:00:00</para>
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-01 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c31238fcb74e482588a72de90cd7dba3</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            [NameInMap("LicenseSpecCode")]
            [Validation(Required=false)]
            public string LicenseSpecCode { get; set; }

            /// <summary>
            /// <para>代表资源组的资源属性字段</para>
            /// </summary>
            [NameInMap("LicenseSpecName")]
            [Validation(Required=false)]
            public string LicenseSpecName { get; set; }

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

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

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
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>68738E75-43C1-5AE5-9F3A-AFEF576D7B5F</para>
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
        public string Success { get; set; }

    }

}
