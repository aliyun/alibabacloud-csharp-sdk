// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePolicyAdvancedConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the strict mode is enabled for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: The strict mode is enabled.</description></item>
        /// <item><description><b>off</b>: The strict mode is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("InternetSwitch")]
        [Validation(Required=false)]
        public string InternetSwitch { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125EEB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
