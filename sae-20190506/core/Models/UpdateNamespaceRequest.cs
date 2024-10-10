// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateNamespaceRequest : TeaModel {
        [NameInMap("EnableMicroRegistration")]
        [Validation(Required=false)]
        public bool? EnableMicroRegistration { get; set; }

        /// <summary>
        /// <para>The short ID of the namespace. You do not need to specify a region ID. We recommend that you configure this parameter. The value of this parameter can be up to 20 characters in length and can contain only lowercase letters and digits.</para>
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
        /// <para>The long ID of the namespace. If you configure this parameter, the long ID take effects and the value of the NameSpaceShortId parameter is ignored. To ensure compatibility, we recommend that you specify a short namespace ID. A long namespace ID follows the <c>&lt;RegionId&gt;:&lt;NamespaceId&gt;</c> format. The <c>NamespaceId</c> variable can contain only lowercase letters and digits. Example: <c>cn-beijing:test</c>. The value of the NamespaceId variable cannot exceed 32 characters in length. For more information about <b>RegionId</b>, you can call the <a href="https://help.aliyun.com/document_detail/126213.html">DescribeRegions</a> operation to obtain the IDs of regions supported by SAE.</para>
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
