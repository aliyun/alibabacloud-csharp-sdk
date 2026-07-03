// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code of the cloud service provider. Valid values:</para>
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
        /// <para>The ID of the data source. The ID is an MD5 hash that is calculated based on the values of other parameters. You can call the <a href="https://api.aliyun-inc.com/#/publishment/document/cloud-siem/863fdf54478f4cc5877e27c2a5fe9e44?tenantUuid=f382fccd88b94c5c8c864def6815b854%5C&activeTabKey=api%7CDescribeDataSourceInstance">DescribeDataSourceInstance</a> operation to obtain the data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing_waf_kafka</para>
        /// </summary>
        [NameInMap("DataSourceInstanceName")]
        [Validation(Required=false)]
        public string DataSourceInstanceName { get; set; }

        /// <summary>
        /// <para>The parameters of the data source, in a JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;paraCode&quot;:&quot;region_code&quot;,&quot;paraValue&quot;:&quot;ap-guangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("DataSourceInstanceParams")]
        [Validation(Required=false)]
        public string DataSourceInstanceParams { get; set; }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_alert_log</para>
        /// </summary>
        [NameInMap("DataSourceInstanceRemark")]
        [Validation(Required=false)]
        public string DataSourceInstanceRemark { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ckafka: Tencent Cloud CKafka.</para>
        /// </description></item>
        /// <item><description><para>obs: Huawei Cloud Object Storage Service (OBS).</para>
        /// </description></item>
        /// <item><description><para>wafApi: the API used to download attack logs from Tencent Cloud Web Application Firewall (WAF).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obs</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of the threat analysis feature is located. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
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
