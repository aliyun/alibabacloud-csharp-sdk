// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddStudioLayoutResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the layout. You can use the ID as a request parameter in the following operations: DeleteStudioLayout, ModifyStudioLayout, and DescribeStudioLayouts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
