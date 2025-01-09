// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateUserDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The log category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dcdn_log_access_l1 (default): access logs.</description></item>
        /// <item><description>dcdn_log_er: Edge Routine logs.</description></item>
        /// <item><description>dcdn_log_waf: firewall logs.</description></item>
        /// <item><description>dcdn_log_ipa: TCP/UDP proxy logs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_er</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <para>The discard rate. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The log fields that you want to include in logs to be delivered. Separate the log fields with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientRequestID,ClientRequestHost</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The name of the delivery task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
