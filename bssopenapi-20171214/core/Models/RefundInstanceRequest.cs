// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class RefundInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required for scenarios that need idempotence. The UUID that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>793F021C-B589-1225-82A9-99232AEBE494</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required for unsubscription scenarios. Valid values: 1 and 0. A value of 1 specifies that the instance is immediately released. A value of 0 specifies that the instance is shut down based on the shutdown policy. This parameter is supported only for specified services. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ImmediatelyRelease")]
        [Validation(Required=false)]
        public string ImmediatelyRelease { get; set; }

        /// <summary>
        /// <para>The ID of the instance. This parameter is required for unsubscription scenarios. Do not specify a custom name for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1etb69sqxgl4*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The code of the service. This parameter is required for unsubscription scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service. This parameter is required for unsubscription scenarios. Unless otherwise specified, set this parameter to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
