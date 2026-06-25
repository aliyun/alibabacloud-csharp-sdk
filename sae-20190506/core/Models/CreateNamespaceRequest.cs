// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the built-in service registry of SAE.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// <para>The default value is true. If you do not use the built-in service registry, set this parameter to false to speed up namespace creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMicroRegistration")]
        [Validation(Required=false)]
        public bool? EnableMicroRegistration { get; set; }

        /// <summary>
        /// <para>The short-format namespace ID. You do not need to specify a region ID. This parameter is recommended. The ID cannot exceed 20 characters in length and can contain only lowercase letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// <para>The description of the namespace. The description cannot exceed 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("NamespaceDescription")]
        [Validation(Required=false)]
        public string NamespaceDescription { get; set; }

        /// <summary>
        /// <para>The long-format namespace ID. If you specify this parameter, NameSpaceShortId is ignored. This parameter is retained for compatibility. Use the short-format namespace ID instead. The format is <c>&lt;RegionId&gt;:&lt;NamespaceId&gt;</c>. The <c>NamespaceId</c> can contain only lowercase letters and digits and cannot exceed 32 characters in length. Example: <c>cn-beijing:test</c>. For information about the regions that SAE supports, see <a href="https://help.aliyun.com/document_detail/126213.html">DescribeRegions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace. The name cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
