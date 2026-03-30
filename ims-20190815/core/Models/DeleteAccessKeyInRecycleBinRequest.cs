// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class DeleteAccessKeyInRecycleBinRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the RAM user.</para>
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
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud account to call the operation, you must specify the parameter.</description></item>
        /// <item><description>If you use a RAM user to call the operation, you can leave the parameter empty. In this case, the ID of the RAM user is used by default.</description></item>
        /// </list>
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
