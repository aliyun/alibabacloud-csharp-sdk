// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetMLServiceResultsRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>true: The request can use a built-in system service.</para>
        /// </description></item>
        /// <item><description><para>false: The request cannot use a built-in system service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowBuiltin")]
        [Validation(Required=false)]
        public bool? AllowBuiltin { get; set; }

        /// <summary>
        /// <para>The request struct.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MLServiceAnalysisParam Body { get; set; }

        /// <summary>
        /// <para>The version number of the algorithm. Different versions correspond to different algorithms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
