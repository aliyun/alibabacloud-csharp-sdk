// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateGrafanaWorkspaceShrinkRequest : TeaModel {
        [NameInMap("AccountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <para>The language. Default value: zh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh</description></item>
        /// <item><description>en</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("CustomAccountNumber")]
        [Validation(Required=false)]
        public string CustomAccountNumber { get; set; }

        /// <summary>
        /// <para>The description of the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.x</para>
        /// </summary>
        [NameInMap("GrafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// <para>The edition.</para>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>standard: <c>Beta Edition or Standard Edition</c></description></item>
        /// <item><description>personal_edition: Developer Edition</description></item>
        /// <item><description>experts_edition: Pro Edition</description></item>
        /// <item><description>advanced_edition: Advanced Edition</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experts_edition</para>
        /// </summary>
        [NameInMap("GrafanaWorkspaceEdition")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceEdition { get; set; }

        /// <summary>
        /// <para>The name of the Grafana workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testgrafana</para>
        /// </summary>
        [NameInMap("GrafanaWorkspaceName")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceName { get; set; }

        /// <summary>
        /// <para>The password of the workspace. The password must be 8 to 30 characters in length. It must include at least three of the following characters types: uppercase letter, lowercase letter, digit, and special character. Special characters include () \&quot; ~ ! @ # $ % ^ &amp; \* - _ + =.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
