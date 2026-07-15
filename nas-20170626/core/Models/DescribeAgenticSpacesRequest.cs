// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAgenticSpacesRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The collection of filter key information.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeAgenticSpacesRequestFilters> Filters { get; set; }
        public class DescribeAgenticSpacesRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AgenticSpaceIds</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AgenticSpaceIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. Wildcards are not supported.</para>
            /// <list type="bullet">
            /// <item><description>AgenticSpaceIds: only a single ID is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>06229oypxjgox0u****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of results per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTc3OTkzNTA0Mjg0NTc1MDI4OCM0MDQ0MzA****=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
