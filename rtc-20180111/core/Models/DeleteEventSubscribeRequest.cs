// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DeleteEventSubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query applications in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9qb1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription ID. For more information, see <a href="https://help.aliyun.com/document_detail/274447.html">CreateEventSubscribe</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad53276431c****</para>
        /// </summary>
        [NameInMap("SubscribeId")]
        [Validation(Required=false)]
        public string SubscribeId { get; set; }

    }

}
