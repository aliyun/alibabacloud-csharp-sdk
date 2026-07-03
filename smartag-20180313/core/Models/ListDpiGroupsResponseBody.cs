// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application groups.</para>
        /// </summary>
        [NameInMap("DpiGroup")]
        [Validation(Required=false)]
        public List<ListDpiGroupsResponseBodyDpiGroup> DpiGroup { get; set; }
        public class ListDpiGroupsResponseBodyDpiGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public string DpiGroupId { get; set; }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P2P</para>
            /// </summary>
            [NameInMap("DpiGroupName")]
            [Validation(Required=false)]
            public string DpiGroupName { get; set; }

            /// <summary>
            /// <para>The minimum version of the deep packet inspection (DPI) engine that supports the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-0.0.1</para>
            /// </summary>
            [NameInMap("MinEngineVersion")]
            [Validation(Required=false)]
            public string MinEngineVersion { get; set; }

            /// <summary>
            /// <para>The minimum version of the signature database that supports the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201117_1_0-0.0.1</para>
            /// </summary>
            [NameInMap("MinSignatureDbVersion")]
            [Validation(Required=false)]
            public string MinSignatureDbVersion { get; set; }

        }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFPSpX59Ebw****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC184A86-3C93-49D6-BB34-6C193E14D37F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of application groups returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
