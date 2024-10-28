// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateSubmissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestToken</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("DefaultRuntime")]
        [Validation(Required=false)]
        public string DefaultRuntime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EntityNames")]
        [Validation(Required=false)]
        public List<string> EntityNames { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestEntityType</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/my-exe-dir/</para>
        /// </summary>
        [NameInMap("ExecuteDirectory")]
        [Validation(Required=false)]
        public string ExecuteDirectory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	        &quot;CallCaching&quot;: false, 	        &quot;DeleteIntermediateResults&quot;: true, 	        &quot;FailureMode&quot;: &quot;NoNewCalls&quot;         }</para>
        /// </summary>
        [NameInMap("ExecuteOptions")]
        [Validation(Required=false)]
        public string ExecuteOptions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/my-output-dir/</para>
        /// </summary>
        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Revision")]
        [Validation(Required=false)]
        public string Revision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProduceVersion</para>
        /// </summary>
        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestWorkspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
