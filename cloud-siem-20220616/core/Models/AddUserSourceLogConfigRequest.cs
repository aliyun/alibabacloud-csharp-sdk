// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddUserSourceLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add or delete the log collection task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>-1: Deletes the task.</para>
        /// </description></item>
        /// <item><description><para>0: Adds the task.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>The detailed information about the SLS log to be collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai.siem-project.siem-logstore</para>
        /// </summary>
        [NameInMap("DisPlayLine")]
        [Validation(Required=false)]
        public string DisPlayLine { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of Threat Analysis is located. Select a region based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in regions outside China.</para>
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
        /// <para>The code of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_aegis_proc</para>
        /// </summary>
        [NameInMap("SourceLogCode")]
        [Validation(Required=false)]
        public string SourceLogCode { get; set; }

        /// <summary>
        /// <para>The detailed information about the Simple Log Service (SLS) log to be collected. The value is a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;project&quot;:&quot;wafnew-project-1335759343513432-cn-hangzhou&quot;,&quot;logStore&quot;:&quot;wafnew-logstore&quot;,&quot;regionCode&quot;:&quot;cn-hangzhou&quot;,&quot;prodCode&quot;:&quot;waf&quot;}</para>
        /// </summary>
        [NameInMap("SourceLogInfo")]
        [Validation(Required=false)]
        public string SourceLogInfo { get; set; }

        /// <summary>
        /// <para>The code of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("SourceProdCode")]
        [Validation(Required=false)]
        public string SourceProdCode { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account for which you want to collect logs.</para>
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
