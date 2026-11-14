// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachProjectManagersToProjectAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The project authorization ID.</para>
        /// <remarks>
        /// <para>You can call the ListProjectAuthorizations operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuthorizationId")]
        [Validation(Required=false)]
        public long? AuthorizationId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The information about the project administrators specified in the project authorization.</para>
        /// </summary>
        [NameInMap("Principals")]
        [Validation(Required=false)]
        public List<AttachProjectManagersToProjectAuthorizationRequestPrincipals> Principals { get; set; }
        public class AttachProjectManagersToProjectAuthorizationRequestPrincipals : TeaModel {
            /// <summary>
            /// <para>The ID of the RAM user or the ARN of the RAM role to be specified as a project administrator. If PrincipalType is set to RamUser, specify the ID of the RAM user. If PrincipalType is set to RamRole, specify the ARN of the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160****2519</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The display name of the RAM user or RAM role specified as the project administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the project administrator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RamUser</b>: Resource Access Management (RAM) user.</para>
            /// </description></item>
            /// <item><description><para><b>RamRole</b>: RAM role.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamUser</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
