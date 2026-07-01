// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetOSSInfoForUploadFileRequest : TeaModel {
        /// <summary>
        /// <para>The business type. Default value: <b>fcMediaSms</b>.</para>
        /// <para>When you create a signature or template and upload <b>More Materials</b>, the value is <b>fcMediaSms</b>.</para>
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
