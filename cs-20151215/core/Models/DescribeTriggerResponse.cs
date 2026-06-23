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
            /// <para>触发器ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>75973497486******</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>触发器名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>集群ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>c259f563386444ebb8d7****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>触发器项目名称。</para>
            /// <para>由应用所在命名空间及应用名称组成，格式为<c>${namespace}/${name}</c>，取值示例：default/test-app。</para>
            /// 
            /// <b>Example:</b>
            /// <para>default/test-app</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>触发器类型。</para>
            /// <para>取值：</para>
            /// <list type="bullet">
            /// <item><description><para><c>deployment</c>：针对无状态应用的触发器。 </para>
            /// </description></item>
            /// <item><description><para><c>application</c>：针对应用中心应用的触发器。</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>deployment</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>触发器行为，取值：</para>
            /// <para><c>redeploy</c>: 重新部署应用。</para>
            /// 
            /// <b>Example:</b>
            /// <para>redeploy</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Token信息。</para>
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
