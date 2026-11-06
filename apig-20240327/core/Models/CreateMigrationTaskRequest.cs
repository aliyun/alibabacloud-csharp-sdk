// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source ACK cluster. It must match the cluster in the IngressInfo of the API. Note: This parameter is required. If it is not provided, the API returns a 400 InvalidParameter.IsEmpty error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxxxxx</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The task description. It is stored in the database only when the task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>migration from Nginx</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the destination environment. It must match the Ingress import environment of the API. Note: This parameter is required. If it is not provided, the API returns a 400 InvalidParameter.IsEmpty error. You can call ListEnvironments to query existing environment IDs. CreateEnvironment is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        [Obsolete]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The ID of the destination gateway to which migration traffic is switched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the HTTP API. The API must be imported as an Ingress type (HttpIngress) API. Note: This parameter is required. If it is not provided, the API returns a 400 InvalidParameter.IsEmpty error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <para>The Ingress class. It must match the API import configuration. Otherwise, an ingress class conflict error is reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("ingressClass")]
        [Validation(Required=false)]
        public string IngressClass { get; set; }

        /// <summary>
        /// <para>The migration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nginx Ingress</para>
        /// </summary>
        [NameInMap("migrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <para>The watched namespace. It must match the API import configuration. Otherwise, a watchNamespace conflict error is reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("watchNamespace")]
        [Validation(Required=false)]
        public string WatchNamespace { get; set; }

    }

}
