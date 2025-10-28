// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertOrUpdateRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37793352-C568-4A5A-BF69-4DC853******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the custom namespace.</para>
        /// </summary>
        [NameInMap("UserDefineRegionEntity")]
        [Validation(Required=false)]
        public InsertOrUpdateRegionResponseBodyUserDefineRegionEntity UserDefineRegionEntity { get; set; }
        public class InsertOrUpdateRegionResponseBodyUserDefineRegionEntity : TeaModel {
            /// <summary>
            /// <para>The ID of the region to which the namespace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether remote debugging is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Remote debugging is enabled.</description></item>
            /// <item><description>false: Remote debugging is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DebugEnable")]
            [Validation(Required=false)]
            public bool? DebugEnable { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logical region</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the namespace is created or modified. If this parameter is left empty or 0 is returned, the namespace is created. Otherwise, the namespace is modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15160</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// <list type="bullet">
            /// <item><description>The ID of a custom namespace is in the <c>region ID:namespace identifier</c> format. Example: cn-beijing:tdy218.</description></item>
            /// <item><description>The ID of the default namespace is in the <c>region ID</c> format. Example: cn-beijing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_region</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the custom namespace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas_****_test@aliyun-****.com</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
