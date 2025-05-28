// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeRequest : TeaModel {
        [NameInMap("CubeIds")]
        [Validation(Required=false)]
        public string CubeIds { get; set; }

        /// <summary>
        /// <para>Expiration time, with a default of seven days.
        /// Format: 2099-12-31</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31</para>
        /// </summary>
        [NameInMap("ExpireDay")]
        [Validation(Required=false)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// <para>Array of analysis theme IDs, separated by English commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubeThemes")]
        [Validation(Required=false)]
        public string LlmCubeThemes { get; set; }

        /// <summary>
        /// <para>Array of Q&amp;A resource IDs, separated by English commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubes")]
        [Validation(Required=false)]
        public string LlmCubes { get; set; }

        /// <summary>
        /// <para>Operation type. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>0: Add authorization</description></item>
        /// <item><description>1: Remove authorization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>Array of user IDs, separated by English commas.</para>
        /// <remarks>
        /// <para>Notice: The number of user IDs per request * (number of Q&amp;A resources + number of analysis themes) cannot exceed 100.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
