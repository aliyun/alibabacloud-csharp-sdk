// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Notification : TeaModel {
        /// <summary>
        /// <para>Use an Object Storage Service (OSS) file to receive task notifications. If you provide the URI of this file, detailed task execution information is written to the file in a JSON structure. Normally, you receive notifications through <a href="https://help.aliyun.com/document_detail/161886.html">EventBridge</a>, <a href="https://help.aliyun.com/document_detail/27412.html">MNS</a>, or <a href="https://help.aliyun.com/document_detail/29530.html">RocketMQ</a>. However, some tasks generate large amounts of information, such as archive previews or decompression tasks. For these tasks, provide this file to get the complete execution results.</para>
        /// <para>The OSS URI format is oss\://${Bucket}/${Object}. <c>${Bucket}</c> is the name of an OSS bucket in the same region as the current project. <c>${Object}</c> is the full path of the file, including the file name extension.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This file is not a notification method. It only serves as a medium to receive detailed task execution information. Task status is sent through standard message notifications. This file contains only the detailed execution information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.json</para>
        /// </summary>
        [NameInMap("ExtendedMessageURI")]
        [Validation(Required=false)]
        public string ExtendedMessageURI { get; set; }

        /// <summary>
        /// <para>The MNS notification parameter object.</para>
        /// </summary>
        [NameInMap("MNS")]
        [Validation(Required=false)]
        public MNS MNS { get; set; }

        /// <summary>
        /// <para>The RocketMQ notification parameter object.</para>
        /// </summary>
        [NameInMap("RocketMQ")]
        [Validation(Required=false)]
        public RocketMQ RocketMQ { get; set; }

    }

}
