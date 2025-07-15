// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMergeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application that generates the output stream. You can view the application name on the <a href="https://help.aliyun.com/document_detail/606583.html">Primary/Secondary Stream Mixing Settings</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The streaming protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rtmp</b>: This is the default value.</description></item>
        /// <item><description><b>rtc</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the output stream. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/606583.html">Primary/Secondary Stream Mixing Settings</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StreamName</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
