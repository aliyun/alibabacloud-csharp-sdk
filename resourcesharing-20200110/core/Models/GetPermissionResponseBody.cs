// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class GetPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the permission.</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public GetPermissionResponseBodyPermission Permission { get; set; }
        public class GetPermissionResponseBodyPermission : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:01.818Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the permission is the default permission. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: The permission is not the default permission.</description></item>
            /// <item><description>true: The permission is the default permission.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultPermission")]
            [Validation(Required=false)]
            public bool? DefaultPermission { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is the default version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: The version is not the default version.</description></item>
            /// <item><description>true: The version is the default version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            /// <summary>
            /// <para>The document of the policy related to the permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Effect&quot;:&quot;Allow&quot;,&quot;Action&quot;:[&quot;vpc:DescribeVSwitches&quot;,&quot;vpc:DescribeVSwitchAttributes&quot;]}</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>The name of the permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunRSDefaultPermissionVSwitch</para>
            /// </summary>
            [NameInMap("PermissionName")]
            [Validation(Required=false)]
            public string PermissionName { get; set; }

            /// <summary>
            /// <para>The version of the permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("PermissionVersion")]
            [Validation(Required=false)]
            public string PermissionVersion { get; set; }

            /// <summary>
            /// <para>The type of the shared resources.</para>
            /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-07T07:39:01.818Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F23CFB6-A721-4E90-AC1E-0E30FA8B45DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
