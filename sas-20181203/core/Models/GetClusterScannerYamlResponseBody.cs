// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterScannerYamlResponseBody : TeaModel {
        /// <summary>
        /// <para>The CA certificate in Base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CaCertBase64")]
        [Validation(Required=false)]
        public string CaCertBase64 { get; set; }

        /// <summary>
        /// <para>The cluster environment context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClusterEnvInfo")]
        [Validation(Required=false)]
        public string ClusterEnvInfo { get; set; }

        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c7c190a82d9a048be9038d352840f****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container image information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-registry.cn-shanghai.cr.aliyuncs.com/default/scanner:v1</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The webhook certificate in Base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TlsCertBase64")]
        [Validation(Required=false)]
        public string TlsCertBase64 { get; set; }

        /// <summary>
        /// <para>The webhook private key in Base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TlsKeyBase64")]
        [Validation(Required=false)]
        public string TlsKeyBase64 { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental scanning is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WebhookOpen")]
        [Validation(Required=false)]
        public int? WebhookOpen { get; set; }

    }

}
