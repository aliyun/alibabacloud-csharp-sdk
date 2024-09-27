// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTriggerResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeTriggerResponseBody> Body { get; set; }
        public class DescribeTriggerResponseBody : TeaModel {
            /// <summary>
            /// <para>The ID of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the associated cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c259f563386444ebb8d7****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// <para>The name consists of the namespace where the application is deployed and the name of the application. The format is <c>${namespace}/${name}</c>. Example: default/test-app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default/test-app</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The type of trigger.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>deployment</c>: performs actions on Deployments.</description></item>
            /// <item><description><c>application</c>: performs actions on applications that are deployed in Application Center.</description></item>
            /// </list>
            /// <para>Default value: <c>deployment</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deployment</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The action that the trigger performs. The value is set to redeploy.</para>
            /// <para><c>redeploy</c>: redeploys the resource specified by project_id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redeploy</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The token information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhbGci***</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
