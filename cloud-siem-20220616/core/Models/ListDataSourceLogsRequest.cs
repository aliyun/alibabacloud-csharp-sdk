// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The code for the cloud service provider. Valid values:</para>
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
        /// <para>The ID of the data source. This ID is an MD5 hash value that is calculated by threat analysis based on specific parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220ba97c9d1fdb0b9c7e8c7ca328d7ea</para>
        /// </summary>
        [NameInMap("DataSourceInstanceId")]
        [Validation(Required=false)]
        public string DataSourceInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the Data Management hub of threat analysis is deployed. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or Hong Kong (China).</para>
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
