// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListUserClusterTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cluster types. Number of elements in the array: 1 to 100.</para>
        /// </summary>
        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<ListUserClusterTypesResponseBodyClusterTypes> ClusterTypes { get; set; }
        public class ListUserClusterTypesResponseBodyClusterTypes : TeaModel {
            /// <summary>
            /// <para>The access type of cluster type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The name of cluster type</para>
            /// 
            /// <b>Example:</b>
            /// <para>AckEdgePro</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

        /// <summary>
        /// <para>NextToken for the next page. Include this value when requesting the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
