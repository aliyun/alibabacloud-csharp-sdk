// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RegisterServiceInput : TeaModel {
        /// <summary>
        /// <para>关联的凭证ID，用于服务认证</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-credential</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>服务的协议类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>关联的资源名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-resource</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>转发的下游服务端点URL，必须是有效的HTTP/HTTPS地址（这里是 FC trigger endpoint）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://123456789.cn-hangzhou.fc.aliyuncs.com/2016-08-15/proxy/my-service/my-function/">https://123456789.cn-hangzhou.fc.aliyuncs.com/2016-08-15/proxy/my-service/my-function/</a></para>
        /// </summary>
        [NameInMap("serviceBackendEndpoint")]
        [Validation(Required=false)]
        public string ServiceBackendEndpoint { get; set; }

        /// <summary>
        /// <para>服务名称，在租户内唯一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-service</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>服务类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>租户ID，用于多租户隔离</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
