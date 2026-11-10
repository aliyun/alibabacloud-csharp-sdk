// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBody : TeaModel {
        [NameInMap("CloudAccountResources")]
        [Validation(Required=false)]
        public List<ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResources> CloudAccountResources { get; set; }
        public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResources : TeaModel {
            /// <summary>
            /// <para>归属云账号ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>资源实体标识，远端唯一标识。</para>
            /// 
            /// <b>Example:</b>
            /// <para>System:AliyunIntelligentcockpitReadOnlyAccessexample</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityId")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityId { get; set; }

            /// <summary>
            /// <para>资源实体类型，枚举值：ram_role。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram_role</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityType")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityType { get; set; }

            /// <summary>
            /// <para>云账号资源标识。</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_xxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountResourceId")]
            [Validation(Required=false)]
            public string CloudAccountResourceId { get; set; }

            [NameInMap("CloudAccountResourceMeta")]
            [Validation(Required=false)]
            public ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResourcesCloudAccountResourceMeta CloudAccountResourceMeta { get; set; }
            public class ListCloudAccountResourcesForCloudPermissionTemplateResponseBodyCloudAccountResourcesCloudAccountResourceMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("CamPolicyDocument")]
                [Validation(Required=false)]
                public string CamPolicyDocument { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qcs</para>
                /// </summary>
                [NameInMap("CamPolicyType")]
                [Validation(Required=false)]
                public string CamPolicyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;2012-10-17&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("IamPolicyDocument")]
                [Validation(Required=false)]
                public string IamPolicyDocument { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aws</para>
                /// </summary>
                [NameInMap("IamPolicyType")]
                [Validation(Required=false)]
                public string IamPolicyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[]}</para>
                /// </summary>
                [NameInMap("RamPolicyDocument")]
                [Validation(Required=false)]
                public string RamPolicyDocument { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("RamPolicyType")]
                [Validation(Required=false)]
                public string RamPolicyType { get; set; }

            }

            /// <summary>
            /// <para>资源名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-sso-role</para>
            /// </summary>
            [NameInMap("CloudAccountResourceName")]
            [Validation(Required=false)]
            public string CloudAccountResourceName { get; set; }

            /// <summary>
            /// <para>创建时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用于SSO单点登录的云账号资源</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>最近一次更新时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649916625000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>分页查询时每页行数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
