// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SubmitImportLogTasksRequest : TeaModel {
        /// <summary>
        /// <para>The list of accounts for log ingestion. The value must be a JSON array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AccountId: The ID of the account.</para>
        /// </description></item>
        /// <item><description><para>Imported: Specifies whether to enable or disable log ingestion for the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Disable ingestion.</para>
        /// </description></item>
        /// <item><description><para>1: Enable ingestion.</para>
        /// </description></item>
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
        /// <para>Specifies whether to automatically enable log ingestion for accounts that are configured with the specified log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Yes.</para>
        /// </description></item>
        /// <item><description><para>0: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoImported")]
        [Validation(Required=false)]
        public int? AutoImported { get; set; }

        /// <summary>
        /// <para>The code of the cloud service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The list of logs to be ingested. The value must be a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cloud_siem_qcloud_cfw_alert_log&quot;]</para>
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public string LogCodes { get; set; }

        /// <summary>
        /// <para>The code of the product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcloud_waf</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The region where the data management center for Threat Analysis is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member that the administrator wants to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts within the enterprise.</para>
        /// </description></item>
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
