// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DescribeOnlineTestResultRequest : TeaModel {
        /// <summary>
        /// <para>The resource type. Valid value: video. If you specify image, audio, or document, the request is rejected and a 400 error is returned with the message &quot;resourceType should be in specific values annotated on @IsIn&quot;. Note: This parameter is actually required. If it is not provided, the API returns a 400 error with the message &quot;resourceType may not be empty&quot;, but the required field remains false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The ID of the detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
