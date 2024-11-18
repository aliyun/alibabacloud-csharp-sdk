// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04677DCA-7C33-464B-8811-1B1DA3C3D197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the principals.</para>
        /// </summary>
        [NameInMap("SharedTargets")]
        [Validation(Required=false)]
        public List<ListSharedTargetsResponseBodySharedTargets> SharedTargets { get; set; }
        public class ListSharedTargetsResponseBodySharedTargets : TeaModel {
            /// <summary>
            /// <para>The time when the principal was associated with the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T09:16:59.905Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the principal is outside the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public bool? External { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-6GRmdD3X****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The ID of the principal or resource owner.</para>
            /// <list type="bullet">
            /// <item><description>If the value of <c>ResourceOwner</c> is <c>Self</c>, the value of this parameter is the ID of a principal.</description></item>
            /// <item><description>If the value of <c>ResourceOwner</c> is <c>OtherAccounts</c>, the value of this parameter is the ID of a resource owner.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>114240524784****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The properties of the principal, such as the time range within which the resource is shared.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the principal is an Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;timeRange&quot;:{
            ///         &quot;timeRangeType&quot;:&quot;timeRange&quot;,
            ///         &quot;beginAtTime&quot;:&quot;00:00&quot;,
            ///         &quot;timezone&quot;:&quot;UTC+8&quot;,
            ///         &quot;endAtTime&quot;:&quot;19:59&quot;
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("TargetProperty")]
            [Validation(Required=false)]
            public string TargetProperty { get; set; }

            /// <summary>
            /// <para>The time when the association of the principal was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T09:16:59.905Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
