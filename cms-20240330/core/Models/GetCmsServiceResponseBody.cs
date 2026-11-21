// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetCmsServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the service or product is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>PROM_NOT_OPEN: Prometheus is not activated.
        /// SLS_NOT_OPEN: Simple Log Service, which Prometheus depends on, is not activated.
        /// CMS_SLR_NOT_EXIST: The CloudMonitor service-linked role is not created.
        /// SLS_SLR_NOT_EXIST: The Simple Log Service service-linked role is not created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROM_NOT_OPEN</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
