// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>You can call ListApplications to obtain the AppId. The call chain is as follows: call CreateApplication to create an application, call PushApplicationData or DistApplicationData to upload data, and then call this operation to query the download URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d9143f0</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the data file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mirror_file/pk-1642597182026-878199448832413.tar</para>
        /// </summary>
        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        /// <summary>
        /// <para>The version number of the data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7895</para>
        /// </summary>
        [NameInMap("DataVersion")]
        [Validation(Required=false)]
        public string DataVersion { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("ExpireTimeout")]
        [Validation(Required=false)]
        public long? ExpireTimeout { get; set; }

        /// <summary>
        /// <para>The filter condition for file servers. Multiple canary release strategies are supported. By default, all file servers are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;name\&quot;: \&quot;ScheduleToRegionId\&quot;,\&quot;parameters\&quot;:{\&quot;operator\&quot;: \&quot;In\&quot;,\&quot;values\&quot;: [\&quot;cn-shijiazhuang-telecom_unicom_cmcc\&quot;]}}</para>
        /// </summary>
        [NameInMap("ServerFilterStrategy")]
        [Validation(Required=false)]
        public string ServerFilterStrategy { get; set; }

    }

}
