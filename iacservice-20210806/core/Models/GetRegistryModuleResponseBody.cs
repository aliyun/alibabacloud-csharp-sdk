// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRegistryModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The Registry template.</para>
        /// </summary>
        [NameInMap("registryModule")]
        [Validation(Required=false)]
        public GetRegistryModuleResponseBodyRegistryModule RegistryModule { get; set; }
        public class GetRegistryModuleResponseBodyRegistryModule : TeaModel {
            /// <summary>
            /// <para>The permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>private: Private.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The creation time in the YYYY-MM-DD HH:mm:ss format. The returned value does not include a time zone identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-28 13:39:05</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of downloads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("downloads")]
            [Validation(Required=false)]
            public int? Downloads { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-cluster</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NamespaceName</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>The provider type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>alicloud: Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The list of accounts that share the Registry template.</para>
            /// </summary>
            [NameInMap("sharedAccounts")]
            [Validation(Required=false)]
            public List<long?> SharedAccounts { get; set; }

            /// <summary>
            /// <para>The template source, which is concatenated in the <NamespaceName>/<ModuleName> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespaceName/ModuleName</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The URL of the template source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("sourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            /// <summary>
            /// <para>The workspace type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system: Public module.</para>
            /// </description></item>
            /// <item><description><para>self: Custom module.</para>
            /// </description></item>
            /// <item><description><para>shared: Shared module.</para>
            /// </description></item>
            /// <item><description><para>community: Community module.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B5AD471-5036-581B-AC9B-7D5EECED877A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
