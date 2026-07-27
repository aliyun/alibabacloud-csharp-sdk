// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DataDesensPlanTemplateValue : TeaModel {
        /// <summary>
        /// <para>The name of the Desensitization Method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether watermarking is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Watermarking is supported.</para>
        /// </description></item>
        /// <item><description><para>false: Watermarking is not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportWaterMark")]
        [Validation(Required=false)]
        public bool? SupportWaterMark { get; set; }

        /// <summary>
        /// <para>A list of Desensitization Parameters and their descriptions.</para>
        /// </summary>
        [NameInMap("ExtParamTemplate")]
        [Validation(Required=false)]
        public List<object> ExtParamTemplate { get; set; }

    }

}
