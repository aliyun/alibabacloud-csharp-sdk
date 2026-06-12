// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListOpsNoticesRequest : TeaModel {
        /// <summary>
        /// <para>The filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListOpsNoticesRequestFilter> Filter { get; set; }
        public class ListOpsNoticesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Type: The notice type.</para>
            /// </description></item>
            /// <item><description><para>ServiceId: The service ID.</para>
            /// </description></item>
            /// <item><description><para>ServiceName: The service name. Fuzzy search is supported. The format for a fuzzy search is \<em>xxx\</em>.</para>
            /// </description></item>
            /// <item><description><para>Category: The notice category.</para>
            /// </description></item>
            /// <item><description><para>Severity: The severity level.</para>
            /// </description></item>
            /// <item><description><para>NoticeId: The O\&amp;M notice ID.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned in the last API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
