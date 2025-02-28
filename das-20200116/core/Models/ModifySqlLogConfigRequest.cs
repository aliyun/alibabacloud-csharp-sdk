// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable DAS Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you want to enable DAS Enterprise Edition. By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ModifySqlLogConfigRequestFilters> Filters { get; set; }
        public class ModifySqlLogConfigRequestFilters : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of days for which the SQL Explorer and Audit data is stored in hot storage. Valid values: 1 to 7.</para>
        /// <remarks>
        /// <para> This parameter is required if only DAS Enterprise Edition V3 can be enabled for the database instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HotRetention")]
        [Validation(Required=false)]
        public int? HotRetention { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rr-2ze770smbq3tpr2o9</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SQL Explorer feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if only DAS Enterprise Edition V3 can be enabled for the database instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequestEnable")]
        [Validation(Required=false)]
        public bool? RequestEnable { get; set; }

        /// <summary>
        /// <para>The total storage duration of the SQL Explorer and Audit data. Unit: day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>7</description></item>
        /// <item><description>30</description></item>
        /// <item><description>180</description></item>
        /// <item><description>365</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to enable DAS Enterprise Edition V3, the value of this parameter must be greater than or equal to 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
