// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListSystemConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The system configuration name.\
        /// callableTime: the outbound job window.\
        /// calleeDailyAttemptLimit: the maximum number of daily calls to a single callee number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>callableTime</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration type ID.\
        /// If ObjectType is set to INSTANCE, this parameter specifies the instance ID.\
        /// If ObjectType is set to TENANT, this parameter specifies the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The configuration type.\
        /// INSTANCE: instance-level.\
        /// TENANT: tenant-level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
