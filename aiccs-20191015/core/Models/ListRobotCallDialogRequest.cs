// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListRobotCallDialogRequest : TeaModel {
        /// <summary>
        /// <para>Unique call ID. You can invoke the <a href="https://help.aliyun.com/document_detail/2717996.html">RobotCall</a> API and check the <b>Data</b> field in the response to obtain it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12516551<b><b>^11195613</b></b></para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>Creation Time. Format: YYYY-MM-DD hh:mm:ss. The time must be precise. You can invoke the <a href="https://help.aliyun.com/document_detail/2717996.html">RobotCall</a> API and view the <b>date</b> parameter in the <b>Response Header</b> of the response to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20 00:00:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
