// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterLayoutResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the layout. You can use this ID as a request parameter when you call operations to manage layouts, such as deleting, modifying, or querying layouts for a production studio or a virtual studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21926b36-7dd2-4fde-ae25-51b5bc8e****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
