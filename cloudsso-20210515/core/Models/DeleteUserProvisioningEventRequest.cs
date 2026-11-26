// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteUserProvisioningEventRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the Resource Access Management (RAM) user synchronization event.</para>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/2636305.html">ListUserProvisioningEvents</a> to retrieve the <c>EventId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upe-wjKyNDmZvyZOiRcJ****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The ID of the Resource Access Management (RAM) user synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-002axzhapcbz6e63****</para>
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
