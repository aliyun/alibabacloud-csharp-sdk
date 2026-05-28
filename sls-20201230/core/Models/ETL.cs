// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETL : TeaModel {
        /// <summary>
        /// <para>The configurations of the data transformation job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ETLConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The time when the data transformation job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274900</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>job description</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETL</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>job displayName</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETL</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The time when the data transformation job was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714274900</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>job name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETL</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the scheduler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f0eb655e501a8780808d1970ef6d04c4</para>
        /// </summary>
        [NameInMap("scheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>The status of the data transformation job. Valid values:</para>
        /// <ol>
        /// <item><description>RUNNING</description></item>
        /// <item><description>STOPPING</description></item>
        /// <item><description>STOPPED</description></item>
        /// <item><description>SUCCEEDED</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>STARTING</description></item>
        /// <item><description>RESTARTING</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
