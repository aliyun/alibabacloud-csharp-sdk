// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud account resources.</para>
        /// </summary>
        [NameInMap("CloudAccountResources")]
        [Validation(Required=false)]
        public List<ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResources> CloudAccountResources { get; set; }
        public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResources : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The resource entity identifier, which is a unique remote identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System:AliyunIntelligentcockpitReadOnlyAccessexample</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityId")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityId { get; set; }

            /// <summary>
            /// <para>The resource entity type. Valid values: ram_role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram_role</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityType")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityType { get; set; }

            /// <summary>
            /// <para>The identifier of the cloud account resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_xxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountResourceId")]
            [Validation(Required=false)]
            public string CloudAccountResourceId { get; set; }

            /// <summary>
            /// <para>The resource metadata.</para>
            /// </summary>
            [NameInMap("CloudAccountResourceMeta")]
            [Validation(Required=false)]
            public ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResourcesCloudAccountResourceMeta CloudAccountResourceMeta { get; set; }
            public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResourcesCloudAccountResourceMeta : TeaModel {
                /// <summary>
                /// <para>The JSON string of the Tencent Cloud CAM policy document. This parameter is returned only for Tencent Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("CamPolicyDocument")]
                [Validation(Required=false)]
                public string CamPolicyDocument { get; set; }

                /// <summary>
                /// <para>The Tencent Cloud CAM policy type. Valid values: qcs and local. This parameter is returned only for Tencent Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qcs</para>
                /// </summary>
                [NameInMap("CamPolicyType")]
                [Validation(Required=false)]
                public string CamPolicyType { get; set; }

                /// <summary>
                /// <para>The JSON string of the AWS IAM policy document. This parameter is returned only for AWS cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;2012-10-17&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("IamPolicyDocument")]
                [Validation(Required=false)]
                public string IamPolicyDocument { get; set; }

                /// <summary>
                /// <para>The AWS IAM policy type. Valid values: aws and local. This parameter is returned only for AWS cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aws</para>
                /// </summary>
                [NameInMap("IamPolicyType")]
                [Validation(Required=false)]
                public string IamPolicyType { get; set; }

                /// <summary>
                /// <para>The JSON string of the RAM policy document. This parameter is returned only by the get operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("RamPolicyDocument")]
                [Validation(Required=false)]
                public string RamPolicyDocument { get; set; }

                /// <summary>
                /// <para>The RAM policy type. Valid values: system and custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("RamPolicyType")]
                [Validation(Required=false)]
                public string RamPolicyType { get; set; }

            }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-sso-role</para>
            /// </summary>
            [NameInMap("CloudAccountResourceName")]
            [Validation(Required=false)]
            public string CloudAccountResourceName { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud account resource used for SSO</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649916625000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned by the current call. Use this token for the next paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
