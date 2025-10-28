// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetAppDeploymentResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the Deployment of the application. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;metadata&quot;:{&quot;name&quot;:&quot;oambuild-group*&quot;,&quot;namespace&quot;:&quot;default&quot;,&quot;selfLink&quot;:&quot;/apis/apps/v1/namespaces/default/deployments/oambuil*&quot;,&quot;uid&quot;:&quot;<em>-afc0-436e-9949-fb01994a9b63&quot;,&quot;resourceVersion&quot;:&quot;969614832&quot;,&quot;generation&quot;:2,&quot;creationTimestamp&quot;:&quot;2021-04-06T11:38:46Z&quot;,&quot;labels&quot;:{&quot;edas-domain&quot;:&quot;edas-admin&quot;,&quot;edas.aliyun.oam.com/rollout-name&quot;:&quot;oambuild-group-1&quot;,&quot;edas.aliyun.oam.com/rollout-namespace&quot;:&quot;default&quot;,&quot;edas.aliyun.oam.com/rollout-revision&quot;:&quot;3&quot;,&quot;edas.appid&quot;:&quot;fc5e0f54-</em>-4cab-91a0-b7becb1f6174&quot;,&quot;edas.controlplane&quot;:&quot;edas-oam&quot;,&quot;edas.oam.acname&quot;:&quot;oambuild&quot;...</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03FD1520-0FD6-436A-<b><b>-265318D7</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
