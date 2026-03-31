// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateDeployRevisionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4DB0****1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;RevisionId&quot;: &quot;rev-0d6c6956faac431c891b&quot;, &quot;ApplicationName&quot;: &quot;AgentColin3&quot;}</para>
        /// </summary>
        [NameInMap("Revision")]
        [Validation(Required=false)]
        public CreateDeployRevisionResponseBodyRevision Revision { get; set; }
        public class CreateDeployRevisionResponseBodyRevision : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AgentColin3</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("DeployResourceType")]
            [Validation(Required=false)]
            public string DeployResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-05</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public string Hooks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;bucketName&quot;:&quot;ecs-application-ui-test&quot;,&quot;objectName&quot;:&quot;319137376-pipeline-run-319137376-task-1-cmd-exec.log&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rev-0d6c6956faac431c891b</para>
            /// </summary>
            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Oss</para>
            /// </summary>
            [NameInMap("RevisionType")]
            [Validation(Required=false)]
            public string RevisionType { get; set; }

        }

    }

}
