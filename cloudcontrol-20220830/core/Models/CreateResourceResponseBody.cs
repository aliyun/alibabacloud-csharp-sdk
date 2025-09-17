// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class CreateResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cctest</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The path of the resources. The relative resource ID. The resource path contains the complete resource location (parent resource/child resource).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance/r-8vbf5abe31c9c4d4/Account/cctest</para>
        /// </summary>
        [NameInMap("resourcePath")]
        [Validation(Required=false)]
        public string ResourcePath { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task. If the operation is asynchronous, this field is returned. In this case, the HTTP status code 202 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-433aead756057fff8189a7ce5****</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
