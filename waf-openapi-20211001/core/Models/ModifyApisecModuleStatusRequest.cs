// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyApisecModuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqtm**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance resides. Valid values:</para>
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
        /// <para>Indicates whether to enable the compliance review feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public long? ReportStatus { get; set; }

        /// <summary>
        /// <para>The name of the protected object group for which you want to modify the API security module status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public string ResourceGroups { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the protected object for which you want to modify the API security module status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cwaf-***-waf</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable the traceability audit feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TraceStatus")]
        [Validation(Required=false)]
        public int? TraceStatus { get; set; }

    }

}
