// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveRequestLogRequest : TeaModel {
        /// <summary>
        /// <para>The account that initiated the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>The API path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/users/login</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103.118.55.**</para>
        /// </summary>
        [NameInMap("ClientIP")]
        [Validation(Required=false)]
        public string ClientIP { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter is available only for hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query information about hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>433</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1726057800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The domain name of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.***.com</para>
        /// </summary>
        [NameInMap("MatchedHost")]
        [Validation(Required=false)]
        public string MatchedHost { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of sensitive data.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000,1001</para>
        /// </summary>
        [NameInMap("SensitiveCode")]
        [Validation(Required=false)]
        public string SensitiveCode { get; set; }

        /// <summary>
        /// <para>The sensitive data in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SensitiveData")]
        [Validation(Required=false)]
        public string SensitiveData { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723392000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
