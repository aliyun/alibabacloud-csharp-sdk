// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("AIDBClusterId")]
        [Validation(Required=false)]
        public string AIDBClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>feishu</para>
        /// </summary>
        [NameInMap("AuthProvider")]
        [Validation(Required=false)]
        public string AuthProvider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AuthProviderConfig")]
        [Validation(Required=false)]
        public string AuthProviderConfig { get; set; }

        [NameInMap("AutoAllocatePublicEip")]
        [Validation(Required=false)]
        public bool? AutoAllocatePublicEip { get; set; }

        [NameInMap("AutoCreatePolarFs")]
        [Validation(Required=false)]
        public bool? AutoCreatePolarFs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public string EndpointsShrink { get; set; }

        [NameInMap("MemApplicationSpec")]
        [Validation(Required=false)]
        public string MemApplicationSpecShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>openai-completions</para>
        /// </summary>
        [NameInMap("ModelApi")]
        [Validation(Required=false)]
        public string ModelApi { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sk-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelApiKey")]
        [Validation(Required=false)]
        public string ModelApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("ModelBaseUrl")]
        [Validation(Required=false)]
        public string ModelBaseUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ModelFrom")]
        [Validation(Required=false)]
        public string ModelFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pcs-********************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SecurityIPArrayName")]
        [Validation(Required=false)]
        public string SecurityIPArrayName { get; set; }

        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        [NameInMap("SkillTemplateId")]
        [Validation(Required=false)]
        public string SkillTemplateId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateApplicationShrinkRequestTag> Tag { get; set; }
        public class CreateApplicationShrinkRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
