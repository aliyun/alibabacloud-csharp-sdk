// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListProjectsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of projects to return. Valid values: 0 to 200. If this parameter is not set or is set to 0, the default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the previous API call. The list of projects is returned in lexicographical order starting from the NextToken value. Leave this parameter empty when you call this API operation for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDAx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The prefix used to filter projects. The length is limited to 0 to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
