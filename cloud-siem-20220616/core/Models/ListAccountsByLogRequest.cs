// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountsByLogRequest : TeaModel {
        /// <summary>
        /// <para>The code of the cloud provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The list of log codes. This parameter is a repeatList array parameter that must be passed in dot-separated expanded form, for example, LogCodes.1=cloud_siem_hcloud_waf_alert_log. Passing a JSON array string directly is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogCodes.1=cloud_siem_hcloud_waf_alert_log</para>
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public List<string> LogCodes { get; set; }

        /// <summary>
        /// <para>The code of the product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qcloud_waf</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The region where the CTDR data management center is located. Select the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the assets belong to the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: the assets belong to regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
