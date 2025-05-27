// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SubmitImportLogTasksRequest : TeaModel {
        /// <summary>
        /// <para>The accounts that you want to add. The value is a JSON array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AccountId: the IDs of the accounts.</para>
        /// </description></item>
        /// <item><description><para>Imported: specifies whether to add the accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no</description></item>
        /// <item><description>1: yes</description></item>
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
        /// <para>Specifies whether to automatically add the account for which the logging feature is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: yes</description></item>
        /// <item><description>0: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cloud_siem_qcloud_cfw_alert_log&quot;]</para>
        /// </summary>
        [NameInMap("AutoImported")]
        [Validation(Required=false)]
        public int? AutoImported { get; set; }

        /// <summary>
        /// <para>The code that is used for multi-cloud environments. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qcloud: Tencent Cloud</description></item>
        /// <item><description>aliyun: Alibaba Cloud</description></item>
        /// <item><description>hcloud: Huawei Cloud</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The logs that you want to collect. The value is a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cloud_siem_qcloud_cfw_alert_log&quot;]</para>
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public string LogCodes { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcloud_waf</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in regions inside China.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the account that you switch from the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the current Alibaba Cloud account</description></item>
        /// <item><description>1: the global account</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
