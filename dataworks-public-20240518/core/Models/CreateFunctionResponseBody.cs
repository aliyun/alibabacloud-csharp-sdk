// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateFunctionResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the UDF function.</para>
        /// <remarks>
        /// <para>Notice: This field was of the Long type in SDK versions earlier than 8.0.0 and is of the String type in SDK 8.0.0 and later. <b>This change does not affect normal SDK usage, and the parameter is still returned in the type defined in the SDK</b>. Only when you upgrade across SDK version 8.0.0, the type change may cause project compilation failures, and you need to manually correct the data type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>580667964888595XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE49C88D-5BEE-5ADD-8B8C-C4BBC0D7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
