// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyDataSourceLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code for the multicloud environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>qcloud: Tencent Cloud.</para>
        /// </description></item>
        /// <item><description><para>aliyun: Alibaba Cloud.</para>
        /// </description></item>
        /// <item><description><para>hcloud: Huawei Cloud.</para>
        /// </description></item>
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
        /// <para>The ID of the data source. The threat analysis feature generates this ID by calculating an MD5 hash of the parameters.
        /// Call the <a href="https://help.aliyun.com/document_detail/2639736.html">DescribeDataSourceInstance</a> operation to obtain the data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef33097c9d1fdb0b9c7e8c7ca320pkl1</para>
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the data source parameters, in a JSON array format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;LogCode&quot;:&quot;cloud_siem_qcloud_waf_alert_log&quot;,&quot;LogParas&quot;:&quot;[{\&quot;ParaCode\&quot;:\&quot;api_name\&quot;,\&quot;ParaValue\&quot;:\&quot;GetAttackDownloadRecords\&quot;}]&quot;}]</para>
        /// </summary>
        [NameInMap("DataSourceInstanceLogs")]
        [Validation(Required=false)]
        public string DataSourceInstanceLogs { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>obs: Huawei Cloud Object Storage Service (OBS).</para>
        /// </description></item>
        /// <item><description><para>wafApi: Tencent Cloud Web Application Firewall (WAF) download API.</para>
        /// </description></item>
        /// <item><description><para>ckafka: Tencent Cloud CKafka.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>obs</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The code of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_waf_xxxxx</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para>The ID of the log. The threat analysis feature generates this ID by calculating an MD5 hash of the parameters. Call the <a href="https://help.aliyun.com/document_detail/2639707.html">ListDataSourceLogs</a> operation to obtain the log ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef33097c9d1fdb0b9c7e8c7ca320pkl1</para>
        /// </summary>
        [NameInMap("LogInstanceId")]
        [Validation(Required=false)]
        public string LogInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the Data Management hub is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or China (Hong Kong).</para>
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

    }

}
