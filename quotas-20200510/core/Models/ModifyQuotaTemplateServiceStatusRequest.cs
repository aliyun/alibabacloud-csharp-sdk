// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyQuotaTemplateServiceStatusRequest : Darabonba.Model {
        /// <summary>
        /// <para>The status of the quota template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>-1: The quota template is disabled.</para>
        /// </description></item>
        /// <item><description><para>1: The quota template is enabled.</para>
        /// </description></item>
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

