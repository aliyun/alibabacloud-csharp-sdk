// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code of the multi-cloud provider.</para>
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
        /// <para>XX Beijing Kafka</para>
        /// </summary>
        [NameInMap("DataSourceInstanceName")]
        [Validation(Required=false)]
        public string DataSourceInstanceName { get; set; }

        /// <summary>
        /// <para>The parameters of the data source. The value is a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;paraCode&quot;:&quot;region_code&quot;,&quot;paraValue&quot;:&quot;ap-guangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("DataSourceInstanceParams")]
        [Validation(Required=false)]
        public string DataSourceInstanceParams { get; set; }

        /// <summary>
        /// <para>The remark of the data source.</para>
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
        /// <item><description>obs: Huawei Cloud OBS.</description></item>
        /// <item><description>wafApi: Tencent Cloud WAF download API. </description></item>
        /// <item><description>ckafka: Tencent Cloud CKafka.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>obs</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. You must select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside China.</description></item>
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
