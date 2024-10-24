// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetOSSInfoForUploadFileRequest : TeaModel {
        /// <summary>
        /// <para>Business type, default value is <b>fcMediaSms</b>.</para>
        /// <para>When creating signatures and templates, and uploading <b>additional materials</b>, this value is <b>fcMediaSms</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcMediaSms</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
