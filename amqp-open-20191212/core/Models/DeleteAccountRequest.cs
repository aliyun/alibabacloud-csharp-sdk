// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteAccountRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp that indicates when the static username and password were created. Unit: milliseconds.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/472730.html">ListAccounts</a> operation to find this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671175303522</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The static username to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MjphbXFwLWNuLXVxbTJ6cjc2djAwMzpMVEFJNX*******ZNMWVSWnRFSjZ2Zm8=</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
