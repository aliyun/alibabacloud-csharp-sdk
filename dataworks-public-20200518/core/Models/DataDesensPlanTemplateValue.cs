// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DataDesensPlanTemplateValue : TeaModel {
        /// <summary>
        /// <para>The name of the masking method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether adding watermarks is allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Allowed.</description></item>
        /// <item><description>false: Not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportWaterMark")]
        [Validation(Required=false)]
        public bool? SupportWaterMark { get; set; }

        /// <summary>
        /// <para>The list of masking parameters and their descriptions.</para>
        /// </summary>
        [NameInMap("ExtParamTemplate")]
        [Validation(Required=false)]
        public List<object> ExtParamTemplate { get; set; }

    }

}
