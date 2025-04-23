// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCommissionDetailFileListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>202501</para>
        /// </summary>
        [NameInMap("BillMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        [NameInMap("OssAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        [NameInMap("OssAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("OssRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

        [NameInMap("OssSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}
