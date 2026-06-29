// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityWatchByObjectIdRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The object ID, such as a table ID, datasource ID, or metric ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc</para>
        /// </summary>
        [NameInMap("WatchObjectId")]
        [Validation(Required=false)]
        public string WatchObjectId { get; set; }

        /// <summary>
        /// <para>The monitored object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TABLE: Dataphin table.</description></item>
        /// <item><description>DATASOURCE_TABLE: global table.</description></item>
        /// <item><description>DATASOURCE: datasource.</description></item>
        /// <item><description>INDEX: metric.</description></item>
        /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("WatchType")]
        [Validation(Required=false)]
        public string WatchType { get; set; }

    }

}
