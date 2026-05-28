// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQL : TeaModel {
        /// <summary>
        /// <para>The configuration of the Scheduled SQL job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ScheduledSQLConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The time when the Scheduled SQL job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714123644</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the scheduled SQL job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a scheduled sql job</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the scheduled SQL job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a scheduled sql job</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The time when the Scheduled SQL job was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714123644</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the scheduled SQL job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-scheduled-sql</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scheduling settings of the Scheduled SQL job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// <para>The ID of the scheduler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e73f43732852064ad5d091914e39342f</para>
        /// </summary>
        [NameInMap("scheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>The status of the Scheduled SQL job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
