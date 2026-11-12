// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudAccountResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud account resource information.</para>
        /// </summary>
        [NameInMap("CloudAccountResource")]
        [Validation(Required=false)]
        public GetCloudAccountResourceResponseBodyCloudAccountResource CloudAccountResource { get; set; }
        public class GetCloudAccountResourceResponseBodyCloudAccountResource : TeaModel {
            /// <summary>
            /// <para>The cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012xxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The unique remote identifier of the resource entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System:AliyunIntelligentcockpitReadOnlyAccess</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityId")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityId { get; set; }

            /// <summary>
            /// <para>The resource entity type. Valid values: ram_policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram_policy</para>
            /// </summary>
            [NameInMap("CloudAccountResourceEntityType")]
            [Validation(Required=false)]
            public string CloudAccountResourceEntityType { get; set; }

            /// <summary>
            /// <para>The cloud account resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_xxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountResourceId")]
            [Validation(Required=false)]
            public string CloudAccountResourceId { get; set; }

            /// <summary>
            /// <para>The resource metadata information.</para>
            /// </summary>
            [NameInMap("CloudAccountResourceMeta")]
            [Validation(Required=false)]
            public GetCloudAccountResourceResponseBodyCloudAccountResourceCloudAccountResourceMeta CloudAccountResourceMeta { get; set; }
            public class GetCloudAccountResourceResponseBodyCloudAccountResourceCloudAccountResourceMeta : TeaModel {
                /// <summary>
                /// <para>The Tencent Cloud CAM policy document in JSON format. This parameter is returned only for Tencent Cloud accounts.</para>
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
                /// <para>The AWS IAM policy document in JSON format. This parameter is returned only for AWS cloud accounts.</para>
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
                /// <para>The RAM policy document in JSON format. This parameter is returned only by the Get operation.</para>
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
            /// <para>The resource name.</para>
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
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649916625000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
