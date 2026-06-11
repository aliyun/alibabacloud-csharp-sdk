// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeRequest : TeaModel {
        /// <summary>
        /// <para>An array of dataset IDs. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>Notice: This parameter is converted to the corresponding Q\&amp;A resource ID for authorization. If a \<c>cubeId\\</c> does not correspond to an existing Q\&amp;A resource, an error is reported that the Q\&amp;A resource does not exist. Ensure that the \<c>cubeId\\</c> is correct.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("CubeIds")]
        [Validation(Required=false)]
        public string CubeIds { get; set; }

        /// <summary>
        /// <para>The expiration time. The default is seven days.
        /// Format: 2099-12-31</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31</para>
        /// </summary>
        [NameInMap("ExpireDay")]
        [Validation(Required=false)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// <para>An array of analysis subject IDs. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubeThemes")]
        [Validation(Required=false)]
        public string LlmCubeThemes { get; set; }

        /// <summary>
        /// <para>An array of Q\&amp;A resource IDs. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubes")]
        [Validation(Required=false)]
        public string LlmCubes { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Grant authorization</para>
        /// </description></item>
        /// <item><description><para>1: Delete authorization</para>
        /// </description></item>
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
        /// <para>An array of user IDs. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>Notice: The number of user IDs × (the number of Q\&amp;A resources + the number of analysis subjects) in a single request cannot exceed 100.</para>
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
