// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdateAccessKeyRequest : TeaModel {
        /// <summary>
        /// <para>The status of the AccessKey pair. Valid values: <c>Active</c> and <c>Inactive</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Inactive</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The AccessKey ID in the AccessKey pair whose status you want to change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0wNEpMMlzy7s****</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>The name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangq****</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
