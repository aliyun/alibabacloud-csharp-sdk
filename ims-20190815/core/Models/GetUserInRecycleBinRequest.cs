// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserInRecycleBinRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>UserId</c> and <c>UserAccessKeyId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI*******************</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>UserId</c> and <c>UserAccessKeyId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20732900249392****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
