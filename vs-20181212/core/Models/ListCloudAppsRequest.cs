// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListCloudAppsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud application. This ID corresponds to a unique application package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aaa.bbb</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Application version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>The time range filter parameter. Express it in ISO8601 standard format, using UTC time: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T02:23:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Return only the latest submitted version of the application. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LatestVersionOnly")]
        [Validation(Required=false)]
        public bool? LatestVersionOnly { get; set; }

        /// <summary>
        /// <para>The page number for the query list. The starting value is 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page for paged queries. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <ol>
        /// <item><description><para>Valid values:
        /// a. hot
        /// b. game
        /// c. app</para>
        /// </description></item>
        /// <item><description><para>Special case:a. To list applications that have no tags, enter NULL.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("PkgLabel")]
        [Validation(Required=false)]
        public string PkgLabel { get; set; }

        /// <summary>
        /// <para>The package type. Valid values:</para>
        /// <ol>
        /// <item><description><para>android</para>
        /// </description></item>
        /// <item><description><para>win</para>
        /// </description></item>
        /// <item><description><para>android_appmarket</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PkgType")]
        [Validation(Required=false)]
        public string PkgType { get; set; }

        /// <summary>
        /// <para>The time range filter parameter. Express it in ISO8601 standard format, using UTC time: yyyy-MM-ddTHH:mm:ssZ.</para>
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
        /// <item><description><para>Success: The desired state, indicating success.</para>
        /// </description></item>
        /// <item><description><para>Failed: The desired state, indicating failure.</para>
        /// </description></item>
        /// <item><description><para>Created</para>
        /// </description></item>
        /// <item><description><para>Doing</para>
        /// </description></item>
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
