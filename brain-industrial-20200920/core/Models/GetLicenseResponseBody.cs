// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetLicenseResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

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
                [NameInMap("ActivateTime")]
                [Validation(Required=false)]
                public string ActivateTime { get; set; }

                [NameInMap("BuyTime")]
                [Validation(Required=false)]
                public string BuyTime { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("LicenseCode")]
                [Validation(Required=false)]
                public string LicenseCode { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>代表资源一级ID的资源属性字段</para>
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
            /// </summary>
            [NameInMap("BuyTime")]
            [Validation(Required=false)]
            public string BuyTime { get; set; }

            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public int? CpuLimit { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// </summary>
            [NameInMap("Fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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

            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public int? MemoryLimit { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnActivateAllDuration")]
            [Validation(Required=false)]
            public string UnActivateAllDuration { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
