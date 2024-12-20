// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class DeleteOuterAccountRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

    }

}
