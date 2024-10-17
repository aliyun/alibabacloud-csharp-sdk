// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BuyPayAsYouGoOrderRequest : TeaModel {
        /// <summary>
        /// <para>The type of the resource that you want to purchase.</para>
        /// <list type="bullet">
        /// <item><description><b>VersionType</b>: DMS that supports control modes</description></item>
        /// <item><description><b>SensitiveDataProtection</b>: DMS that supports sensitive data protection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SensitiveDataProtection</para>
        /// </summary>
        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// <para>The number of database instances that you want to use DMS to manage.</para>
        /// <remarks>
        /// <para>A quota can be used for only one database instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("InsNum")]
        [Validation(Required=false)]
        public int? InsNum { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The control mode of DMS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>stand</b>: Stable Change</description></item>
        /// <item><description><b>safety</b>: Security Collaboration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stand</para>
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

    }

}
