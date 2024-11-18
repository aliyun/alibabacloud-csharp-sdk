// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Tensorboard : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>datasource-test</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:00Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:00Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210114104214-vf9lowjt3pso</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Delete by user</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Tensorboard is deleted</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/root/data</para>
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        [NameInMap("SummaryRelativePath")]
        [Validation(Required=false)]
        public string SummaryRelativePath { get; set; }

        [NameInMap("TensorboardDataSources")]
        [Validation(Required=false)]
        public List<TensorboardDataSourceSpec> TensorboardDataSources { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tensorboard-xxx</para>
        /// </summary>
        [NameInMap("TensorboardId")]
        [Validation(Required=false)]
        public string TensorboardId { get; set; }

        [NameInMap("TensorboardSpec")]
        [Validation(Required=false)]
        public TensorboardSpec TensorboardSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxxxx">http://xxxxxx</a></para>
        /// </summary>
        [NameInMap("TensorboardUrl")]
        [Validation(Required=false)]
        public string TensorboardUrl { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lycxxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tensorboard.pai</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("Workspaceid")]
        [Validation(Required=false)]
        public string Workspaceid { get; set; }

    }

}
