// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListVscsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of data entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used in the next request to retrieve a new page of results. If you leave this parameter empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIdsShrink { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2xdkc6icwfha</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListVscsShrinkRequestTag> Tag { get; set; }
        public class ListVscsShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key001</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value001</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VSC name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("VscName")]
        [Validation(Required=false)]
        public string VscName { get; set; }

    }

}
