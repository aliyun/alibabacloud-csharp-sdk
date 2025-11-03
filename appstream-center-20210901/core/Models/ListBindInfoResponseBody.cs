// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBindInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The bindings.</para>
        /// </summary>
        [NameInMap("BindInfoModels")]
        [Validation(Required=false)]
        public List<ListBindInfoResponseBodyBindInfoModels> BindInfoModels { get; set; }
        public class ListBindInfoResponseBodyBindInfoModels : TeaModel {
            /// <summary>
            /// <para>The account type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ad: Active Directory (AD) account</description></item>
            /// <item><description>simple: convenience account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The app ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-fq738or6vd854****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0abxhr6ce35w8****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the app instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-83oe276fre4l3****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The app version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The product type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudApp: App Streaming</description></item>
            /// <item><description>CloudBrowser: Cloud-based Browser</description></item>
            /// <item><description>AndroidCloud: Cloud Phone</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud Workspace user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2ca6f5a93536****</para>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169-D3F8D19C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
