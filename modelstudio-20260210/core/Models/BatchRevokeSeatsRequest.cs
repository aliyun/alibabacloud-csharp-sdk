// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class BatchRevokeSeatsRequest : TeaModel {
        /// <summary>
        /// <para>The list of revocation items. This parameter is required.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<BatchRevokeSeatsRequestItems> Items { get; set; }
        public class BatchRevokeSeatsRequestItems : TeaModel {
            /// <summary>
            /// <para>The ID of the currently associated member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acc_123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

        }

        /// <summary>
        /// <para>The language. Valid values: zh-CN and en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

    }

}
