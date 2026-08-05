// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobRequest : TeaModel {
        /// <summary>
        /// <para>The list of clip segments. The output is produced by concatenating the segments in the list in order. JSON Array.</para>
        /// <para>Each segment contains a start time and an end time. If no live stream parameters are specified, the outer-level live stream configuration is used. Both start and end timestamps are in UTC. For parameter details, see the Clip data structure below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; ,  &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;},  {\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:05:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:09:00Z\&quot; }]</para>
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public string Clips { get; set; }

        /// <summary>
        /// <para>The live stream configuration. JSON Object. The following configuration items are required:</para>
        /// <list type="bullet">
        /// <item><description><para>AppName: the name of the application to which the stream belongs. </para>
        /// </description></item>
        /// <item><description><para>DomainName: the domain name.</para>
        /// </description></item>
        /// <item><description><para>StreamName: the name of the live stream.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;  }</para>
        /// </summary>
        [NameInMap("LiveStreamConfig")]
        [Validation(Required=false)]
        public string LiveStreamConfig { get; set; }

        /// <summary>
        /// <para>The composition configuration for generating segments, in JSON format. Mode specifies the editing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AccurateFast</b> (default): fast accurate editing. This mode is faster than the Accurate mode. The output file resolution is the same as the source stream resolution. Custom output width and height are not supported.</description></item>
        /// <item><description><b>Accurate</b>: accurate editing. You can specify the output width and height.</description></item>
        /// <item><description><b>Rough</b>: rough editing. The minimum precision is one TS segment. The output contains all segments within the specified start and end time. You can specify the output width and height.</description></item>
        /// <item><description><b>RoughFast</b>: fast rough editing. This mode is faster than the Accurate mode. The minimum precision is one TS segment. The output contains all segments within the specified start and end time. The output file resolution is the same as the source stream resolution. Custom output width and height are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Mode&quot;: &quot;AccurateFast&quot;}</para>
        /// </summary>
        [NameInMap("MediaProduceConfig")]
        [Validation(Required=false)]
        public string MediaProduceConfig { get; set; }

        /// <summary>
        /// <para>The destination configuration for the output. JSON Object. You can specify the URL of the output on OSS or the storage location in a VOD bucket.</para>
        /// <list type="bullet">
        /// <item><description>When outputting to OSS, the MediaURL of the output destination is required.</description></item>
        /// <item><description>When outputting to VOD, the StorageLocation and FileName parameters are required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;MediaURL&quot;: &quot;<a href="https://ice-auto-test.oss-cn-shanghai.aliyuncs.com/testfile.mp4">https://ice-auto-test.oss-cn-shanghai.aliyuncs.com/testfile.mp4</a>&quot; }, or { &quot;StorageLocation&quot;: &quot;bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;FileName&quot;: &quot;output.mp4&quot; }</para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The target type of the output. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss-object: an OSS object in an Alibaba Cloud OSS bucket.</description></item>
        /// <item><description>vod-media: a media asset in Alibaba Cloud VOD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <para>The ID of the live editing project. If this parameter is not empty, the storage configuration associated with the project is used. If this parameter is empty, the storage configuration specified in the request parameters is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The custom settings. JSON Object. Maximum length: 512 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
