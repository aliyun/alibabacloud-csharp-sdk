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
        /// <para>PROM_NOT_OPEN: Prometheus is not activated.SLS_NOT_OPEN: Simple Log Service (SLS), a dependency of Prometheus, is not activated.CMS_SLR_NOT_EXIST: The service-linked role (SLR) for CloudMonitor does not exist.SLS_SLR_NOT_EXIST: The SLR for SLS does not exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROM_NOT_OPEN</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
