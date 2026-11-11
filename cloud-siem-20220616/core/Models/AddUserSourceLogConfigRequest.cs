// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddUserSourceLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the ingestion action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: Deletes the ingestion.</description></item>
        /// <item><description>0: Adds the ingestion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>The detailed Simple Log Service (SLS) information for log ingestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai.siem-project.siem-logstore</para>
        /// </summary>
        [NameInMap("DisPlayLine")]
        [Validation(Required=false)]
        public string DisPlayLine { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The log code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_aegis_proc</para>
        /// </summary>
        [NameInMap("SourceLogCode")]
        [Validation(Required=false)]
        public string SourceLogCode { get; set; }

        /// <summary>
        /// <para>The detailed Simple Log Service (SLS) information for log ingestion in JSON format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;project&quot;:&quot;wafnew-project-1335759343513432-cn-hangzhou&quot;,&quot;logStore&quot;:&quot;wafnew-logstore&quot;,&quot;regionCode&quot;:&quot;cn-hangzhou&quot;,&quot;prodCode&quot;:&quot;waf&quot;}</para>
        /// </summary>
        [NameInMap("SourceLogInfo")]
        [Validation(Required=false)]
        public string SourceLogInfo { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("SourceProdCode")]
        [Validation(Required=false)]
        public string SourceProdCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID for log ingestion.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123XXXXXX</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
