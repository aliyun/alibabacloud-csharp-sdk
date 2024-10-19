// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateAppKeyRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111053351</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application AppKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204203237</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The application AppSecret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6f0a4ad7918a4b41a57fc087d5b066d0</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
