// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateNetworkAccessEndpointRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Network access endpoint name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xx-business VPC access endpoint</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointName")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointName { get; set; }

        /// <summary>
        /// <para>List of specified vSwitches connected to the network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-examplexxx</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>VPC ID connected to the network access endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-examplexxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Region of the VPC ID connected to the network access endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
