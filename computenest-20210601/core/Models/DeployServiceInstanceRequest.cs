// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class DeployServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Ensures idempotency of the request. Generate a unique value for this parameter from your client to ensure it is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Region ID. Allowed values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: East China 1 (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Singapore.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-b58c874912fc4294****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
