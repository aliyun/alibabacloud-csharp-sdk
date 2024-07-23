// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPartitionsHeatmapRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzrciqy62c****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time range to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LAST_ONE_HOURS</b>: the last hour.</description></item>
        /// <item><description><b>LAST_SIX_HOURS</b>: the last six hours.</description></item>
        /// <item><description><b>LAST_ONE_DAYS</b>: the last day.</description></item>
        /// <item><description><b>LAST_THREE_DAYS</b>: the last three days.</description></item>
        /// <item><description><b>LAST_SEVEN_DAYS</b>: the last seven days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LAST_SIX_HOURS</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

        /// <summary>
        /// <para>The type of the data to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>READ_ROWS</b>: the read rows.</description></item>
        /// <item><description><b>WRITTEN_ROWS</b>: the written rows.</description></item>
        /// <item><description><b>READ_WRITTEN_ROWS</b>: the read and written rows.</description></item>
        /// <item><description><b>UPDATE_ROWS</b>: the updated rows.</description></item>
        /// <item><description><b>INSERTED_ROWS</b>: the inserted rows.</description></item>
        /// <item><description><b>DELETED_ROWS</b>: the deleted rows.</description></item>
        /// <item><description><b>READ_ROWS_WITH_DN</b>: the read rows returned from a data node.</description></item>
        /// <item><description><b>WRITTEN_ROWS_WITH_DN</b>: the written rows returned from a data node.</description></item>
        /// <item><description><b>READ_WRITTEN_ROWS_WITH_DN</b>: the read and written rows returned from a data node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WRITTEN_ROWS_WITH_DN</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
