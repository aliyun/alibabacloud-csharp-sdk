// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteMFADeviceForUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the MFA device.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/333531.html">ListMFADevicesForUser</a> operation to query the IDs of MFA devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mfa-00ujhet8pycljj7j****</para>
        /// </summary>
        [NameInMap("MFADeviceId")]
        [Validation(Required=false)]
        public string MFADeviceId { get; set; }

        /// <summary>
        /// <para>The ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
