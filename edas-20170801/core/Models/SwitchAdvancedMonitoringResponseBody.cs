// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SwitchAdvancedMonitoringResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the advanced application monitoring feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The advanced application monitoring feature is enabled.</description></item>
        /// <item><description>false: The advanced application monitoring feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AdvancedMonitoringEnabled")]
        [Validation(Required=false)]
        public bool? AdvancedMonitoringEnabled { get; set; }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The advanced monitoring status is disabled already for application which app_id is 9e224bc6-a646-4484-ae31-e617b7e7****</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>577AED12-32D8-40B6-991F-17D7A601****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
