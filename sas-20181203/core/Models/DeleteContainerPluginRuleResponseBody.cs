// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the container escape prevention rule is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The rule is deleted.</description></item>
        /// <item><description><b>false</b>: The rule failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
