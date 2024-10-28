// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateRunShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentieon</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTIzNDU2P1dvcmtzcGFjZT93cy1mMDE4OTgxNGU1ZTkK</para>
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
        /// <b>Example:</b>
        /// <para>test run</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/exec/</para>
        /// </summary>
        [NameInMap("ExecuteDirectory")]
        [Validation(Required=false)]
        public string ExecuteDirectory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	&quot;CallCaching&quot;: true,     &quot;FailureMode&quot;: &quot;NoNewCalls&quot; }</para>
        /// </summary>
        [NameInMap("ExecuteOptions")]
        [Validation(Required=false)]
        public string ExecuteOptionsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{         &quot;workflow1.task1.param1&quot;: &quot;helloooo.txt&quot;,         &quot;workflow1.task1.param2&quot;: &quot;abc&quot;,         &quot;workflow1.task2.param1&quot;: &quot;new_helloooo.txt&quot;,         &quot;workflow1.task2.param2&quot;: &quot;def&quot;     }</para>
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;: &quot;test&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://my-bucket/output/</para>
        /// </summary>
        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProduceVersion</para>
        /// </summary>
        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestRole</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wgs_sentieon_hc_with_qc_NGPTS1900029301</para>
        /// </summary>
        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
