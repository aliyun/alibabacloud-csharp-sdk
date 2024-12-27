// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateBatchRequest : TeaModel {
        /// <summary>
        /// <para>The processing templates.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<UpdateBatchRequestActions> Actions { get; set; }
        public class UpdateBatchRequestActions : TeaModel {
            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc/convert</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template parameters.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        /// <summary>
        /// <para>The ID of the batch processing task. You can obtain the ID of the batch processing task from the response of the <a href="https://help.aliyun.com/document_detail/606694.html">CreateBatch</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch-4eb9223f-3e88-42d3-a578-3f2852******</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The input data source.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The custom tags. You can search for or filter asynchronous tasks by custom tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;val&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
