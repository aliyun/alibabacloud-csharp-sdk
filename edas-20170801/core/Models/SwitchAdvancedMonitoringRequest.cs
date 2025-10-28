// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SwitchAdvancedMonitoringRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application for which you want to query or configure the advanced application monitoring feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9e224bc6-a646-4484-<b><b>-e617b7e7</b></b></para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the advanced application monitoring feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the advanced application monitoring feature.</description></item>
        /// <item><description>false: disables the advanced application monitoring feature.</description></item>
        /// </list>
        /// <para>If you call this operation to query the status of the advanced application monitoring feature, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdvancedMonitoring")]
        [Validation(Required=false)]
        public bool? EnableAdvancedMonitoring { get; set; }

    }

}
