// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class AllocateCostCenterResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>637180</para>
        /// </summary>
        [NameInMap("FromCostCenterId")]
        [Validation(Required=false)]
        public long? FromCostCenterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1529600453335198</para>
        /// </summary>
        [NameInMap("FromOwnerAccountId")]
        [Validation(Required=false)]
        public long? FromOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostCenterResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostCenterResourceRequestResourceInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>qwer1-cn-beijing</para>
            /// </summary>
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>split-item-test1</para>
            /// </summary>
            [NameInMap("ApportionName")]
            [Validation(Required=false)]
            public string ApportionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RESOURCE_UDR</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("PipCode")]
            [Validation(Required=false)]
            public string PipCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>related-resource</para>
            /// </summary>
            [NameInMap("RelatedResources")]
            [Validation(Required=false)]
            public string RelatedResources { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xihe_mpp</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou;standard</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs-test-1</para>
            /// </summary>
            [NameInMap("ResourceNick")]
            [Validation(Required=false)]
            public string ResourceNick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO_ALLOCATE</para>
            /// </summary>
            [NameInMap("ResourceSource")]
            [Validation(Required=false)]
            public string ResourceSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag-test1</para>
            /// </summary>
            [NameInMap("ResourceTag")]
            [Validation(Required=false)]
            public string ResourceTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SCU</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>273394581313325532</para>
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceUserName")]
            [Validation(Required=false)]
            public string ResourceUserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>638288</para>
        /// </summary>
        [NameInMap("ToCostCenterId")]
        [Validation(Required=false)]
        public long? ToCostCenterId { get; set; }

    }

}
