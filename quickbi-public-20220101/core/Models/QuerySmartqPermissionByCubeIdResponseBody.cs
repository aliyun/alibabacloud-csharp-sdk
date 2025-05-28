// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QuerySmartqPermissionByCubeIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>617277******************ABA47E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Basic information of the dataset.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QuerySmartqPermissionByCubeIdResponseBodyResult Result { get; set; }
        public class QuerySmartqPermissionByCubeIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <para>Dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CubeName")]
            [Validation(Required=false)]
            public string CubeName { get; set; }

            /// <summary>
            /// <para>Whether the current user has permission for the smart question. Note: \&quot;HasPerssion\&quot; seems to be a typo, it should probably be \&quot;HasPermission\&quot;.</para>
            /// </summary>
            [NameInMap("HasPerssion")]
            [Validation(Required=false)]
            public bool? HasPerssion { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
