// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ResetUserPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The method to notify the user after the password is reset.</para>
        /// <remarks>
        /// <para>Alibaba Cloud accounts of the international site do not support sending notification through text messages.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public int? NotifyType { get; set; }

        /// <summary>
        /// <para>The names of the convenience users whose passwords you want to reset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
