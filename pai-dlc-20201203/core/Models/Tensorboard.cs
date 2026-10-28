// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Tensorboard : TeaModel {
        /// <summary>
        /// <para>The visibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The CPU resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource-test</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The dataset type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The creation time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The end time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The modification time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:00Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210114104214-vf9lowjt3pso</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The maximum running duration in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>240</para>
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// <para>The memory size in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>The extended fields of the dataset in JSON format. Currently, MountPath is supported, which specifies the mount path for a custom dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mountpath&quot;:&quot;/root/data/&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The priority of the Tensorboard job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The ID of the resource group used by Tensorboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota12***</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The name of the resource quota used by Tensorboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The status detail code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The status details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/data</para>
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        /// <summary>
        /// <para>The absolute path of the summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/summary/</para>
        /// </summary>
        [NameInMap("SummaryRelativePath")]
        [Validation(Required=false)]
        public string SummaryRelativePath { get; set; }

        /// <summary>
        /// <para>The datasets mounted to the Tensorboard job.</para>
        /// </summary>
        [NameInMap("TensorboardDataSources")]
        [Validation(Required=false)]
        public List<TensorboardDataSourceSpec> TensorboardDataSources { get; set; }

        /// <summary>
        /// <para>The Tensorboard ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorboard-xxx</para>
        /// </summary>
        [NameInMap("TensorboardId")]
        [Validation(Required=false)]
        public string TensorboardId { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go configuration for the Tensorboard job.</para>
        /// </summary>
        [NameInMap("TensorboardSpec")]
        [Validation(Required=false)]
        public TensorboardSpec TensorboardSpec { get; set; }

        /// <summary>
        /// <para>The Tensorboard URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxxx">http://xxxxxx</a></para>
        /// </summary>
        [NameInMap("TensorboardUrl")]
        [Validation(Required=false)]
        public string TensorboardUrl { get; set; }

        /// <summary>
        /// <para>The token value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9*****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lycxxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorboard.pai</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
