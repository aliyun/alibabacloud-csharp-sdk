// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetHealthCheckTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the health check template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hct-x4jazoyi6tvsq9****</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

    }

}
