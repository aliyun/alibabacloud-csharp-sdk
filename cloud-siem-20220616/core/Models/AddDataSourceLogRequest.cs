// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code of the multi-cloud provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qcloud: Tencent Cloud.</description></item>
        /// <item><description>hcloud: Huawei Cloud.</description></item>
        /// <item><description>aliyun: Alibaba Cloud. This value is only used for Alibaba Cloud data source scenarios. When you query available multi-cloud data source types, the ListDataSourceTypes operation only supports qcloud and hcloud.</description></item>
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
        /// <para>The ID of the data source instance. You can call the ListBindDataSources operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the data source parameters. The value is a JSON array.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;LogCode&quot;:&quot;cloud_siem_qcloud_waf_alert_log&quot;,&quot;LogParas&quot;:&quot;[{\&quot;ParaCode\&quot;:\&quot;api_name\&quot;,\&quot;ParaValue\&quot;:\&quot;GetAttackDownloadRecords\&quot;}]&quot;}]</para>
        /// </summary>
        [NameInMap("DataSourceInstanceLogs")]
        [Validation(Required=false)]
        public string DataSourceInstanceLogs { get; set; }

        /// <summary>
        /// <para>The log code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_waf_xxxxx</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Cloud Threat Detection and Response (CTDR) is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Your assets are located outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
