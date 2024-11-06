// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnUserRealTimeDeliveryFieldRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cdn_log_access_l1</b>: access logs of L1 Dynamic Route for CDN (DCDN) points of presence (POPs)</description></item>
        /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
        /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The list of fields. Separate multiple fields with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/324199.html">Fields in a real-time log</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body_bytes_sent,client_ip,content_type</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

    }

}
