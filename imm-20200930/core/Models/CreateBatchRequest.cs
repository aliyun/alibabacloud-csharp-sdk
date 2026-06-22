// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBatchRequest : TeaModel {
        /// <summary>
        /// <para>A list of processing templates.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<CreateBatchRequestActions> Actions { get; set; }
        public class CreateBatchRequestActions : TeaModel {
            /// <summary>
            /// <para>The fast-fail policy configuration.</para>
            /// </summary>
            [NameInMap("FastFailPolicy")]
            [Validation(Required=false)]
            public FastFailPolicy FastFailPolicy { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc/convert</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A list of template parameters.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        /// <summary>
        /// <para>The input data source configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        /// <summary>
        /// <para>The notification recipient. Multiple middleware services are supported. For details about the message format, see Asynchronous notification message. Select one of the following methods to receive messages:</para>
        /// <para>Activate and access EventBridge in the same region as Intelligent Media Management (IMM) to promptly receive task notifications. For more information, see IMM events.
        /// Activate MNS in the same region as IMM and configure a subscription.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public CreateBatchRequestNotification Notification { get; set; }
        public class CreateBatchRequestNotification : TeaModel {
            /// <summary>
            /// <para>The parameters for MNS notifications.</para>
            /// </summary>
            [NameInMap("MNS")]
            [Validation(Required=false)]
            public MNS MNS { get; set; }

        }

        /// <summary>
        /// <para>The project name. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The service role that grants IMM the permissions to access other cloud resources, such as OSS. The default value is AliyunIMMBatchTriggerRole.</para>
        /// <para>To use a custom service role, create a service role and grant permissions to the role in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a service role</a> and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunIMMBatchTriggerRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// <para>Custom tags used to search and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;val&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
