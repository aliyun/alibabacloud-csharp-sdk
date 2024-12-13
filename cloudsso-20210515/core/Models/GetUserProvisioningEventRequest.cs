// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningEventRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user provisioning event.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2636305.html">ListUserProvisioningEvents</a> operation to query the value of <c>EventId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upe-wjKyNDmZvyZOiRcJ****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

    }

}
