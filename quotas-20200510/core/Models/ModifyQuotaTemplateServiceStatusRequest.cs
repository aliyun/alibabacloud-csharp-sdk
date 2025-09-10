// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyQuotaTemplateServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The status of the quota template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\-1: The quota template is disabled.</description></item>
        /// <item><description>1: The quota template is enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public int? ServiceStatus { get; set; }

    }

}
