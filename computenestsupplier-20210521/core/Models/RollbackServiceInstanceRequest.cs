// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class RollbackServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Ensures idempotence of the request. Generate a value from your client to ensure it is unique across different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Service instance ID.</para>
        /// <para>You can obtain the service instance ID by calling <a href="https://help.aliyun.com/document_detail/396200.html">ListServiceInstances - Query Service Instance List</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-3a8f9a75da074f52b969</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
