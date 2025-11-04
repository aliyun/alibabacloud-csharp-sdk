// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartAIWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The tag for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DispatchTag")]
        [Validation(Required=false)]
        public string DispatchTag { get; set; }

        /// <summary>
        /// <para>A JSON string containing the specific input parameters, such as information about the media assets, standard live streams, or RTC streams.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;live_url&quot;: {
        ///         &quot;Url&quot;: &quot;rtmp://test.com/test_app/test_stream?auth_key=test&quot;,
        ///         &quot;MaxIdleTime&quot;: 20
        ///     },
        ///     &quot;source_language_id&quot;: &quot;es&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        /// <summary>
        /// <para>A user-defined parameter for passing custom metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;url&quot;:&quot;<a href="https://test.com">https://test.com</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3f44-f1f6-477e-9364-c5e6c49e</b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
