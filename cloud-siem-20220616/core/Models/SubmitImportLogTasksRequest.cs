// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SubmitImportLogTasksRequest : TeaModel {
        /// <summary>
        /// <para>The list of accounts to be onboarded, in JSON array format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AccountId: the ID of the account to be onboarded.</description></item>
        /// <item><description>Imported: specifies whether to onboard or disconnect the account. Valid values:<list type="bullet">
        /// <item><description>0: Disconnect the account.</description></item>
        /// <item><description>1: Onboard the account.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;AccountId&quot;:&quot;123123&quot;,&quot;Imported&quot;:1}]</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public string Accounts { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically onboard accounts that are configured with the log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Automatically onboard. </description></item>
        /// <item><description>0: Do not automatically onboard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoImported")]
        [Validation(Required=false)]
        public int? AutoImported { get; set; }

        /// <summary>
        /// <para>The multi-cloud code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The list of logs to be onboarded, in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cloud_siem_qcloud_cfw_alert_log&quot;]</para>
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public string LogCodes { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcloud_waf</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The region of the data management center for Threat Analysis. You must select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Current Alibaba Cloud account view.</description></item>
        /// <item><description>1: View of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
