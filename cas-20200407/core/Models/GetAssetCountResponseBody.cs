// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetAssetCountResponseBody : TeaModel {
        [NameInMap("AliyunAssetCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCount { get; set; }

        [NameInMap("AwsAssetCount")]
        [Validation(Required=false)]
        public int? AwsAssetCount { get; set; }

        [NameInMap("BuyCertificateCount")]
        [Validation(Required=false)]
        public int? BuyCertificateCount { get; set; }

        [NameInMap("DomainAssetCount")]
        [Validation(Required=false)]
        public int? DomainAssetCount { get; set; }

        [NameInMap("FreeCertificateCount")]
        [Validation(Required=false)]
        public int? FreeCertificateCount { get; set; }

        [NameInMap("HuaweiAssetCount")]
        [Validation(Required=false)]
        public int? HuaweiAssetCount { get; set; }

        [NameInMap("LastPoint")]
        [Validation(Required=false)]
        public int? LastPoint { get; set; }

        [NameInMap("Point")]
        [Validation(Required=false)]
        public int? Point { get; set; }

        [NameInMap("PointRatio")]
        [Validation(Required=false)]
        public int? PointRatio { get; set; }

        [NameInMap("PointTime")]
        [Validation(Required=false)]
        public long? PointTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EECA10D5-BD0F-4EF1-B3EA-B4578E5C6F8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TencentAssetCount")]
        [Validation(Required=false)]
        public int? TencentAssetCount { get; set; }

        [NameInMap("UploadCertificateCount")]
        [Validation(Required=false)]
        public int? UploadCertificateCount { get; set; }

    }

}
