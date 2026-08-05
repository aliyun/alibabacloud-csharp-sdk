// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BA0504F-B179-586D-8210-A7C7C09A9907</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response result</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateWorkspaceResponseBodyResult Result { get; set; }
        public class CreateWorkspaceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Billing type</para>
            /// <list type="bullet">
            /// <item><description>POSTPAY: Pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Commodity code</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch_platform_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>Workspace description</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Custom domain name prefix</para>
            /// 
            /// <b>Example:</b>
            /// <para>defalult-xxxx</para>
            /// </summary>
            [NameInMap("domainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Engine type</para>
            /// 
            /// <b>Example:</b>
            /// <para>rag</para>
            /// </summary>
            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>Workspace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>120142804</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Workspace instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops-xxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Workspace name</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Quota</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public CreateWorkspaceResponseBodyResultQuota Quota { get; set; }
            public class CreateWorkspaceResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// <para>Compute resource</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// <para>Storage capacity</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// <para>Specification</para>
                /// 
                /// <b>Example:</b>
                /// <para>rag.share.common</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>Resource group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Tags</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResponseBodyResultTags> Tags { get; set; }
            public class CreateWorkspaceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>Tag key</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>Tag value</para>
                /// 
                /// <b>Example:</b>
                /// <para>c</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
