// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>618F2626-DB27-5187-8C6C-4E61A491DF29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The protected objects.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeDefenseResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The status of the tracking cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0:</b> disabled.</description></item>
            /// <item><description><b>1:</b> enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AcwCookieStatus")]
            [Validation(Required=false)]
            public int? AcwCookieStatus { get; set; }

            /// <summary>
            /// <para>The status of the secure attribute in the tracking cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0:</b> disabled.</description></item>
            /// <item><description><b>1:</b> enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwSecureStatus")]
            [Validation(Required=false)]
            public int? AcwSecureStatus { get; set; }

            /// <summary>
            /// <para>The status of the secure attribute in the slider CAPTCHA cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0:</b> disabled.</description></item>
            /// <item><description><b>1:</b> enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwV3SecureStatus")]
            [Validation(Required=false)]
            public int? AcwV3SecureStatus { get; set; }

            /// <summary>
            /// <para>The custom XFF headers that are used to identify the originating IP addresses of clients. If the value of XffStatus is 1 and CustomHeaders is left empty, the first IP addresses in the XFF headers are used as the originating IP addresses of clients.</para>
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            /// <summary>
            /// <para>The description of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The details of the protected object. Different key-value pairs indicate different attributes of the protected object.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            /// <summary>
            /// <para>The time when the protected object was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652149203187</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the protected object was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665633032000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135*********46</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The pattern in which the protected object is protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The name of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The name of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-rencs***</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The name of the protected object group to which the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm***q</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The origin of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResourceOrigin")]
            [Validation(Required=false)]
            public string ResourceOrigin { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-Forwarded-For (XFF) proxy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
