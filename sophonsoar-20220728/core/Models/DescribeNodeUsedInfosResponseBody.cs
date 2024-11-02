// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNodeUsedInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The node reference information. The value is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>action</b>: the referencing action. This field contains the following information:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the referencing node.</description></item>
        /// <item><description><b>inputParams</b>: the parameter settings of the referencing node.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;action&quot;: [
        ///         {
        ///             &quot;name&quot;: &quot;query_books&quot;,
        ///             &quot;inputParams&quot;: [
        ///                 {
        ///                     &quot;referInfos&quot;: [
        ///                         &quot;${play_group.datalist.*.ids}&quot;
        ///                     ],
        ///                     &quot;name&quot;: &quot;querySql&quot;
        ///                 }
        ///             ]
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("NodeUsedInfos")]
        [Validation(Required=false)]
        public string NodeUsedInfos { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B10F836-C2B1-54FA-AB59-7591B548FB59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
