// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListCloudAppsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud application ID, which corresponds to a unique application package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aaa.bbb</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>The start time for time range filtering. Specify the time in the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T02:23:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only the latest submitted version of each application. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LatestVersionOnly")]
        [Validation(Required=false)]
        public bool? LatestVersionOnly { get; set; }

        /// <summary>
        /// <para>The page number of the query list. Minimum value: 1.
        /// Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Valid values: 1 to 100.
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The cloud application label.</para>
        /// <ol>
        /// <item><description>Valid values:
        /// a. hot
        /// b. game
        /// c. app</description></item>
        /// <item><description>Special case:
        /// a. To query applications without a label, enter &quot;NULL&quot;.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("PkgLabel")]
        [Validation(Required=false)]
        public string PkgLabel { get; set; }

        /// <summary>
        /// <para>The installation package type. Valid values:</para>
        /// <ol>
        /// <item><description>android</description></item>
        /// <item><description>win</description></item>
        /// <item><description>android_appmarket</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PkgType")]
        [Validation(Required=false)]
        public string PkgType { get; set; }

        /// <summary>
        /// <para>The start time for time range filtering. Specify the time in the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-29T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The application upload status. Valid values:</para>
        /// <ol>
        /// <item><description>Success: desired state, succeeded.</description></item>
        /// <item><description>Failed: desired state, failed.</description></item>
        /// <item><description>Created</description></item>
        /// <item><description>Doing</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
