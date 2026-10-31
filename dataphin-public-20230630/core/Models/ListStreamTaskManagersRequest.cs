// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamTaskManagersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Flink deployment instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7db678957dc449aab0086b931c9f8218</para>
        /// </summary>
        [NameInMap("DeploymentInstanceId")]
        [Validation(Required=false)]
        public string DeploymentInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the operating tenant. After the gateway verifies that the current identity has access to the tenant, it injects the tenant ID into the backend.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The optional ID of the operating user. This parameter follows the identity verification rules of the gateway and is not directly bound to the backend user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7299592831043008</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
