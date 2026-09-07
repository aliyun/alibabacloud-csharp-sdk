// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateGrafanaWorkspaceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Account quantity.  </para>
        /// <para><b>Value description:</b>  </para>
        /// <list type="bullet">
        /// <item><description>If GrafanaWorkspaceEdition is <b>standard</b>, this parameter is invalid.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>personal_edition</b>, this parameter is invalid. Default Value: 1.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>experts_edition</b>, valid values are 10, 30, or 50. Default Value: 10.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>advanced_edition</b>, this parameter is invalid. Default Value: 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
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

        /// <summary>
        /// <para>Whether auto-renewal is enabled. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>true: Auto-renewal is enabled.  </description></item>
        /// <item><description>false: Auto-renewal is disabled.</description></item>
        /// </list>
        /// <para>Default Value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Additional custom account quantity for the User.  </para>
        /// <para><b>Value description:</b>  </para>
        /// <list type="bullet">
        /// <item><description>If GrafanaWorkspaceEdition is <b>standard</b>, this parameter is invalid.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>personal_edition</b>, this parameter is invalid.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>experts_edition</b>, this parameter is invalid.  </description></item>
        /// <item><description>If GrafanaWorkspaceEdition is <b>advanced_edition</b>, the value range is 0 to 2000 and must be a multiple of 10. Default Value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
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

        /// <summary>
        /// <para>Subscription duration of the instance. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>If PricingCycle is <b>Month</b>, indicating monthly billing, the value range is <b>1</b> to <b>9</b>.  </description></item>
        /// <item><description>If PricingCycle is <b>Year</b>, indicating yearly billing, the value range is <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <para>Default Value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>Grafana version.</para>
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

        /// <summary>
        /// <para>包年包月的计费周期，取值： Month（默认值）：按月购买。                                 Year：按年购买。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
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
