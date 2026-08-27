// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-xxxxxx</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>migration from Nginx</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-xxxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("ingressClass")]
        [Validation(Required=false)]
        public string IngressClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Nginx Ingress</para>
        /// </summary>
        [NameInMap("migrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("watchNamespace")]
        [Validation(Required=false)]
        public string WatchNamespace { get; set; }

    }

}
