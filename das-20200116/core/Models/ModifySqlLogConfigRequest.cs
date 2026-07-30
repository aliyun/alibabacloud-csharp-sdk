// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable DAS Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables DAS Enterprise Edition.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables DAS Enterprise Edition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you enable DAS Enterprise Edition. By default, this operation enables the latest supported version.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable security audit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
        /// <para>The hot storage retention period, in days. The value must be an integer from 1 to 7.</para>
        /// <remarks>
        /// <para>This parameter is required only if you enable DAS Enterprise Edition V3.</para>
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
        /// <para>rr-2ze770smbq3tp****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable SQL Explorer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables SQL Explorer.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables SQL Explorer.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only if you enable DAS Enterprise Edition V3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequestEnable")]
        [Validation(Required=false)]
        public bool? RequestEnable { get; set; }

        /// <summary>
        /// <para>The data retention period, in days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>7</para>
        /// </description></item>
        /// <item><description><para>30</para>
        /// </description></item>
        /// <item><description><para>180</para>
        /// </description></item>
        /// <item><description><para>365</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you enable DAS Enterprise Edition V3, the value of this parameter must be 30 or greater.</para>
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
