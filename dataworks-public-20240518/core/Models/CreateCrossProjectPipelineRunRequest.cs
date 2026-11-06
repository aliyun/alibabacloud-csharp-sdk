// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCrossProjectPipelineRunRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cross-workspace deployment environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("DeploymentEnvironmentId")]
        [Validation(Required=false)]
        public long? DeploymentEnvironmentId { get; set; }

        /// <summary>
        /// <para>The deployment description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a workflow created by calling the API operation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of top-level object IDs from the source project to be deployed. The list must contain exactly one object. Sub-objects of composite objects such as workflows are automatically included by the system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;]</para>
        /// </summary>
        [NameInMap("ObjectIds")]
        [Validation(Required=false)]
        public List<string> ObjectIds { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The deployment type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
