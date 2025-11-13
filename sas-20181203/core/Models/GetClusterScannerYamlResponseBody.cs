// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterScannerYamlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CaCertBase64")]
        [Validation(Required=false)]
        public string CaCertBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClusterEnvInfo")]
        [Validation(Required=false)]
        public string ClusterEnvInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c7c190a82d9a048be9038d352840f****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-registry.cn-shanghai.cr.aliyuncs.com/default/scanner:v1</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TlsCertBase64")]
        [Validation(Required=false)]
        public string TlsCertBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TlsKeyBase64")]
        [Validation(Required=false)]
        public string TlsKeyBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WebhookOpen")]
        [Validation(Required=false)]
        public int? WebhookOpen { get; set; }

    }

}
