// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceDashboardReport : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1680861352600</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>grafana-cn-**********</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1680861352600</para>
        /// </summary>
        [NameInMap("lastSendTime")]
        [Validation(Required=false)]
        public long? LastSendTime { get; set; }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>******@aliyun.com</para>
        /// </summary>
        [NameInMap("reportChannelTarget")]
        [Validation(Required=false)]
        public string ReportChannelTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Email</para>
        /// </summary>
        [NameInMap("reportChannelType")]
        [Validation(Required=false)]
        public string ReportChannelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Grid,Simple</para>
        /// </summary>
        [NameInMap("reportStyle")]
        [Validation(Required=false)]
        public string ReportStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Image</para>
        /// </summary>
        [NameInMap("reportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("triggerDay")]
        [Validation(Required=false)]
        public string TriggerDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12:25</para>
        /// </summary>
        [NameInMap("triggerTime")]
        [Validation(Required=false)]
        public string TriggerTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ByWeek</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Dashboard URL</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
