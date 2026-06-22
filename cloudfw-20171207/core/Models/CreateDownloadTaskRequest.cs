// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateDownloadTaskRequest : TeaModel {
        /// <summary>
        /// <para>The language of the received messages.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: (default) Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The query conditions for the download task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SearchItem\&quot;:\&quot;\&quot;,\&quot;UserType\&quot;:\&quot;buy\&quot;,\&quot;IpVersion\&quot;:\&quot;4\&quot;}</para>
        /// </summary>
        [NameInMap("TaskData")]
        [Validation(Required=false)]
        public string TaskData { get; set; }

        /// <summary>
        /// <para>The task type. For valid values, call the API operation that queries file download task types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewallAsset</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The time zone for time information in the downloaded file. The value is an IANA time zone identifier. Default value: Asia/Shanghai (UTC+8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
