// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DeleteGroupRequest : TeaModel {
        /// <summary>
        /// <para>The group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g123</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
