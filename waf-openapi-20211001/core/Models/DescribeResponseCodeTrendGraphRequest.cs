// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: seconds. If you do not specify this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665386280</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>The time interval. Unit: seconds. The value must be an integral multiple of 60.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The ID of the region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1:</b> outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The protected object.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

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
        /// <para>The beginning of the time range to query. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665331200</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// <para>The type of the error codes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:</b> error codes that are returned to clients from WAF.</description></item>
        /// <item><description><b>upstream:</b> error codes that are returned to WAF from the origin server.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
