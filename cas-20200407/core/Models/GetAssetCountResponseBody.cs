// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetAssetCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of Alibaba Cloud resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AliyunAssetCount")]
        [Validation(Required=false)]
        public int? AliyunAssetCount { get; set; }

        /// <summary>
        /// <para>The total number of Amazon Web Services (AWS) resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AwsAssetCount")]
        [Validation(Required=false)]
        public int? AwsAssetCount { get; set; }

        /// <summary>
        /// <para>The number of paid certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyCertificateCount")]
        [Validation(Required=false)]
        public int? BuyCertificateCount { get; set; }

        /// <summary>
        /// <para>The total number of domain name resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DomainAssetCount")]
        [Validation(Required=false)]
        public int? DomainAssetCount { get; set; }

        /// <summary>
        /// <para>The number of free certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FreeCertificateCount")]
        [Validation(Required=false)]
        public int? FreeCertificateCount { get; set; }

        /// <summary>
        /// <para>The total number of Huawei Cloud resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("HuaweiAssetCount")]
        [Validation(Required=false)]
        public int? HuaweiAssetCount { get; set; }

        /// <summary>
        /// <para>The previous health score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LastPoint")]
        [Validation(Required=false)]
        public int? LastPoint { get; set; }

        /// <summary>
        /// <para>The generated perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Point")]
        [Validation(Required=false)]
        public int? Point { get; set; }

        /// <summary>
        /// <para>The health score ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PointRatio")]
        [Validation(Required=false)]
        public int? PointRatio { get; set; }

        /// <summary>
        /// <para>The time when the health score was updated (in timestamp format, accurate to seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1767681210879</para>
        /// </summary>
        [NameInMap("PointTime")]
        [Validation(Required=false)]
        public long? PointTime { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EECA10D5-BD0F-4EF1-B3EA-B4578E5C6F8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Tencent Cloud resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TencentAssetCount")]
        [Validation(Required=false)]
        public int? TencentAssetCount { get; set; }

        /// <summary>
        /// <para>The number of uploaded certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UploadCertificateCount")]
        [Validation(Required=false)]
        public int? UploadCertificateCount { get; set; }

    }

}
