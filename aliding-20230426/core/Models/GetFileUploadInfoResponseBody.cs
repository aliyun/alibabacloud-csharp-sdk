// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFileUploadInfoResponseBody : TeaModel {
        [NameInMap("headerSignatureInfo")]
        [Validation(Required=false)]
        public GetFileUploadInfoResponseBodyHeaderSignatureInfo HeaderSignatureInfo { get; set; }
        public class GetFileUploadInfoResponseBodyHeaderSignatureInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("ExpirationSeconds")]
            [Validation(Required=false)]
            public int? ExpirationSeconds { get; set; }

            [NameInMap("Headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            [NameInMap("InternalResourceUrls")]
            [Validation(Required=false)]
            public List<string> InternalResourceUrls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZHANGJIAKOU</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResourceUrls")]
            [Validation(Required=false)]
            public List<string> ResourceUrls { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HEADER_SIGNATURE</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DINGTALK</para>
        /// </summary>
        [NameInMap("storageDriver")]
        [Validation(Required=false)]
        public string StorageDriver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
