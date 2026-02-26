// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Notification : TeaModel {
        /// <summary>
        /// <para>The Object Storage Service (OSS) URI of the object that stores task notifications. Task information is written to the object in the JSON format. In most cases, you can receive notifications only by using <a href="https://help.aliyun.com/document_detail/161886.html">EventBridge</a>, <a href="https://help.aliyun.com/document_detail/27412.html">Simple Message Queue</a>, or <a href="https://help.aliyun.com/document_detail/29530.html">ApsaraMQ for RocketMQ</a>. For tasks that have a large amount of task information, such as archive file inspection tasks and decompression tasks, you can use an OSS object to store detailed task information.</para>
        /// <para>The OSS URI follows the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <remarks>
        /// <para> The object is not a messaging method. It serves only as a container for detailed task information. Task status information is sent as a message, whereas the object stores detailed task information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.json</para>
        /// </summary>
        [NameInMap("ExtendedMessageURI")]
        [Validation(Required=false)]
        public string ExtendedMessageURI { get; set; }

        /// <summary>
        /// <para>The SMQ notification settings.</para>
        /// </summary>
        [NameInMap("MNS")]
        [Validation(Required=false)]
        public MNS MNS { get; set; }

        /// <summary>
        /// <para>The ApsaraMQ for RocketMQ notification settings.</para>
        /// </summary>
        [NameInMap("RocketMQ")]
        [Validation(Required=false)]
        public RocketMQ RocketMQ { get; set; }

    }

}
