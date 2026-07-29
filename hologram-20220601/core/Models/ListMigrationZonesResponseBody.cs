// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListMigrationZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A token used to retrieve the next page of results. This parameter is not returned if no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of availability zones.</para>
        /// </summary>
        [NameInMap("zoneList")]
        [Validation(Required=false)]
        public List<ListMigrationZonesResponseBodyZoneList> ZoneList { get; set; }
        public class ListMigrationZonesResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the instance can be migrated to the availability zone. A value of false indicates that the migration conditions are not met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// <para>The ID of the availability zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
