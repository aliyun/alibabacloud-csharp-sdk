// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetKubernetesTriggerResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetKubernetesTriggerResponseBody> Body { get; set; }
        public class GetKubernetesTriggerResponseBody : TeaModel {
            /// <summary>
            /// <para>The trigger ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The trigger name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c259f563386444ebb8d7**</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The trigger project name.</para>
            /// <para>The value consists of the namespace and application name in the format of <c>${namespace}/${name}</c>. Example: default/test-app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default/test-app</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The trigger type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>deployment</c>: a trigger for a stateless application. </para>
            /// </description></item>
            /// <item><description><para><c>application</c>: a trigger for an application center application.</para>
            /// </description></item>
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
            /// <para>The trigger action. Valid values:</para>
            /// <para><c>redeploy</c>: redeploys the resources defined in project_id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redeploy</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Token</para>
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
