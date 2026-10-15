// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListAuthConfigByResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FA14C-ED6B-5F39-8563-855676470C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of authorization details.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAuthConfigByResourceResponseBodyResult> Result { get; set; }
        public class ListAuthConfigByResourceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The array of permissions granted.</para>
            /// </summary>
            [NameInMap("Authorities")]
            [Validation(Required=false)]
            public List<string> Authorities { get; set; }

            /// <summary>
            /// <para>The ID of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123**dfsd</para>
            /// </summary>
            [NameInMap("AuthorizedId")]
            [Validation(Required=false)]
            public string AuthorizedId { get; set; }

            /// <summary>
            /// <para>The name of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sss</para>
            /// </summary>
            [NameInMap("AuthorizedName")]
            [Validation(Required=false)]
            public string AuthorizedName { get; set; }

            /// <summary>
            /// <para>The expiration time. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788969600000</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The time when the permission record was created, in the yyyy-MM-dd mm:hh:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-16 13:17:39</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123**dfsd</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dashboard: dashboard</description></item>
            /// <item><description>screen: data screen</description></item>
            /// <item><description>report: electron</description></item>
            /// <item><description>ANALYSIS: ad hoc analysis</description></item>
            /// <item><description>dashboardOfflineQuery: self-service data retrieval</description></item>
            /// <item><description>dataForm: data form</description></item>
            /// <item><description>cube: dataset</description></item>
            /// <item><description>datasource: data source</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cube</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The authorization scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: user</description></item>
            /// <item><description>1: user group</description></item>
            /// <item><description>2: organization</description></item>
            /// <item><description>3: workspace</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
