// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EnsureSharedPrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. zh indicates Chinese, and en indicates English. Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The share scope. Currently, only Workspace is supported, which indicates the shared Prometheus instance for the workspace in the requested region. Workspaces in the same region share the same instance, and no additional instances are created. Policy and Environment are not currently supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workspace</para>
        /// </summary>
        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public string ShareScope { get; set; }

        /// <summary>
        /// <para>The name of the workspace. If the workspace does not exist, a 404 error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-workspace</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
