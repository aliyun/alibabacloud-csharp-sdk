// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentAssetFormResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the asset in the component. The value is a JSON array and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the parameter name.</description></item>
        /// <item><description><b>defaultValue</b>: the default parameter value.</description></item>
        /// <item><description><b>description</b>: the parameter description.</description></item>
        /// <item><description><b>required</b>: indicates whether the parameter is required. Valid values: <b>true</b> and <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;defaultValue&quot;: &quot;&quot;,
        ///         &quot;description&quot;: &quot;assetname&quot;,
        ///         &quot;name&quot;: &quot;assetname&quot;,
        ///         &quot;required&quot;: true
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("ComponentAssetForm")]
        [Validation(Required=false)]
        public string ComponentAssetForm { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D1651AC-31CC-5CC4-A14E-626B3FCC1022</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
