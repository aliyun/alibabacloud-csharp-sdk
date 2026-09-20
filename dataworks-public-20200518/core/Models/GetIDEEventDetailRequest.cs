// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetIDEEventDetailRequest : TeaModel {
        /// <summary>
        /// <para>The message ID of the DataWorks open message. After an extension point event is triggered, you can obtain the message ID from the received event message.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;For the message format, refer to <a href="https://help.aliyun.com/document_detail/215367.html">Message format</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed67****1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can obtain the workspace ID by parsing the DataWorks open message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
