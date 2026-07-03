// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code for the multicloud service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX-Beijing-Kafka</para>
        /// </summary>
        [NameInMap("DataSourceInstanceName")]
        [Validation(Required=false)]
        public string DataSourceInstanceName { get; set; }

        /// <summary>
        /// <para>The parameters for the data source. The value must be a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;paraCode&quot;:&quot;region_code&quot;,&quot;paraValue&quot;:&quot;ap-guangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("DataSourceInstanceParams")]
        [Validation(Required=false)]
        public string DataSourceInstanceParams { get; set; }

        /// <summary>
        /// <para>The remarks on the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX Cloud Firewall Shanghai instance</para>
        /// </summary>
        [NameInMap("DataSourceInstanceRemark")]
        [Validation(Required=false)]
        public string DataSourceInstanceRemark { get; set; }

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
        /// <para>The region of the data management center for threat analysis. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: For assets in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: For assets in regions outside China.</para>
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
