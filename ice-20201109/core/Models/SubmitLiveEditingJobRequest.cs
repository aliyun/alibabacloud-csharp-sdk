// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobRequest : TeaModel {
        /// <summary>
        /// <para>The clips in the JSON array format. The output video is created by merging these clips sequentially.</para>
        /// <para>Each clip has a start time and an end time. If no live stream parameters are specified, the outer live stream configurations apply. The start and end timestamps are in UTC. For more information about the parameters, see the &quot;Clip&quot; section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; ,  &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;},  {\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:05:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:09:00Z\&quot; }]</para>
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public string Clips { get; set; }

        /// <summary>
        /// <para>The live stream configurations, in the JSON format. The configurations must include the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>AppName: the name of the application to which the live stream belongs.</description></item>
        /// <item><description>DomainName: the domain name of the application.</description></item>
        /// <item><description>StreamName: the name of the live stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;  }</para>
        /// </summary>
        [NameInMap("LiveStreamConfig")]
        [Validation(Required=false)]
        public string LiveStreamConfig { get; set; }

        /// <summary>
        /// <para>The production configurations, in the JSON format. Mode specifies the editing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AccurateFast</b> (default): fast editing. It is faster than the Accurate mode. The resolution of the output file is the same as that of the source stream. You cannot specify the width and height of the output file.</description></item>
        /// <item><description><b>Accurate</b>: accurate editing. In this mode, you can specify the width and height of the output file.</description></item>
        /// <item><description><b>Rough</b>: rough editing. The minimum precision is one TS segment. The output file comprises all segments within the specified time range. You can specify the width and height of the output file.</description></item>
        /// <item><description><b>RoughFast</b>: fast rough editing. It is faster than the Accurate mode. The minimum precision is one TS segment. The output file comprises all segments within the specified time range. The resolution of the output file is the same as that of the source stream. You cannot specify the width and height of the output file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Mode&quot;: &quot;AccurateFast&quot;}</para>
        /// </summary>
        [NameInMap("MediaProduceConfig")]
        [Validation(Required=false)]
        public string MediaProduceConfig { get; set; }

        /// <summary>
        /// <para>The configurations of the output file, in the JSON format. You can specify an OSS URL or a storage location in a storage bucket of ApsaraVideo VOD.</para>
        /// <list type="bullet">
        /// <item><description>To store the output file in OSS, you must specify MediaURL.</description></item>
        /// <item><description>To store the output file in ApsaraVideo VOD, you must specify StorageLocation and FileName.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The type of the output file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss-object: OSS object in an OSS bucket.</description></item>
        /// <item><description>vod-media: media asset in Alibaba Cloud VOD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <para>The ID of the live editing project. If this parameter is specified, the system reads the storage configurations of the project. If this parameter is not specified, the specified storage configurations take precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
