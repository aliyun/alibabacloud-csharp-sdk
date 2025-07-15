// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamPushMetricDetailDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. The stream-level data of this application is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The accelerated domain name. You can specify only one domain name. If you specify multiple domain names, an error occurs.</description></item>
        /// <item><description>If you do not specify the AppName and StreamName parameters, data of all streams under the specified domain name is returned. The data is not aggregated.</description></item>
        /// <item><description>If you specify the DomainName parameter and set both the AppName and StreamName parameters to all, data of all streams in all applications under the specified domain name is aggregated and returned.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time, and the maximum time range that can be specified is one day. Specify the time in the ISO 8601 standard</para>
        /// <para>in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A pagination token. When you call this operation, up to 5,000 rows of data can be returned per query. If the number of rows exceeds 5,000, the response includes a pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>When you specify the token in the next query, data continues to be obtained from the end of the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67C***37C0=</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream. The data of the stream in the specified application is returned. If the StreamName parameter is specified, the AppName parameter must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
