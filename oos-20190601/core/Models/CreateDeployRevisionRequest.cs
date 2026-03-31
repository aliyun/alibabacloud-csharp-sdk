// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateDeployRevisionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentColin3</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("DeployResourceType")]
        [Validation(Required=false)]
        public string DeployResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-03</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;applicationStart&quot;:&quot;# Execute build process\nbuild() {\n  REPO_URL=\&quot;<a href="https://github.com/aldinokemal/go-whatsapp-web-multidevice.git%5C%5C%22%5C%5Cn">https://github.com/aldinokemal/go-whatsapp-web-multidevice.git\\&quot;\\n</a>  BRANCH=\&quot;main\&quot;\n  DOCKERFILE_PATH=\&quot;./dockerfile\&quot;\n  &quot;}</para>
        /// </summary>
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
        /// <para>Command</para>
        /// </summary>
        [NameInMap("RevisionType")]
        [Validation(Required=false)]
        public string RevisionType { get; set; }

    }

}
