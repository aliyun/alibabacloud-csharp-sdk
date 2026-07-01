// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobRequest : TeaModel {
        /// <summary>
        /// <para>A JSON array that specifies the clips to edit. The job creates the output file by concatenating these clips in the specified order.</para>
        /// <para>Each clip includes a start and end time. If live stream parameters are not specified for a clip, the system uses the global <c>LiveStreamConfig</c> settings. The start and end timestamps must be in UTC. For more details, see the Clip data structure below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; ,  &quot;AppName&quot;: &quot;app&quot;, &quot;DomainName&quot;: &quot;domain.com&quot;, &quot;StreamName&quot;: &quot;stream&quot;},  {\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:05:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:09:00Z\&quot; }]</para>
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public string Clips { get; set; }

        /// <summary>
        /// <para>The configuration of the source live stream, specified as a JSON object. It includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>AppName</c>: The name of the application to which the stream belongs.</para>
        /// </description></item>
        /// <item><description><para><c>DomainName</c>: The domain name of the stream.</para>
        /// </description></item>
        /// <item><description><para><c>StreamName</c>: The name of the live stream.</para>
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
        /// <para>The production configuration for the output file, specified as a JSON object. The <c>Mode</c> parameter specifies the editing mode. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AccurateFast</b> (Default): Fast and precise editing. It offers faster processing compared to the <c>Accurate</c> mode. The output file has the same resolution as the source stream. You cannot specify a custom width and height for the output file.</para>
        /// </description></item>
        /// <item><description><para><b>Accurate</b>: Precise editing. This mode lets you specify a custom width and height for the output file.</para>
        /// </description></item>
        /// <item><description><para><b>Rough</b>: Rough editing with a precision of a single TS segment. The output file includes all segments between the specified start and end times. You can specify a custom width and height for the output file.</para>
        /// </description></item>
        /// <item><description><para><b>RoughFast</b>: Fast rough-cut editing, which is faster than the <c>Accurate</c> mode. It has a precision of a single TS segment, and the output file includes all segments between the specified start and end times. The output file has the same resolution as the source stream. You cannot specify a custom width and height for the output file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Mode&quot;: &quot;AccurateFast&quot;}</para>
        /// </summary>
        [NameInMap("MediaProduceConfig")]
        [Validation(Required=false)]
        public string MediaProduceConfig { get; set; }

        /// <summary>
        /// <para>The destination configuration for the output file, specified as a JSON object. You can specify either a URL on OSS or a storage location in a VOD bucket.</para>
        /// <list type="bullet">
        /// <item><description><para>To output to OSS, the <c>MediaURL</c> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>To output to VOD, the <c>StorageLocation</c> and <c>FileName</c> parameters are required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;MediaURL&quot;: &quot;<a href="https://ice-auto-test.oss-cn-shanghai.aliyuncs.com/testfile.mp4">https://ice-auto-test.oss-cn-shanghai.aliyuncs.com/testfile.mp4</a>&quot; }, or { &quot;StorageLocation&quot;: &quot;bucket.oss-cn-shanghai.aliyuncs.com&quot;, &quot;FileName&quot;: &quot;output.mp4&quot; }</para>
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// <para>The destination type for the output file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>oss-object</c>: An object in an Alibaba Cloud OSS bucket.</para>
        /// </description></item>
        /// <item><description><para><c>vod-media</c>: A media asset in Alibaba Cloud VOD.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-object</para>
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// <para>The ID of the live editing project. If you specify this parameter, the system uses the storage settings from the project. If left empty, the system uses the storage settings provided in the request instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Custom user data, provided as a JSON object. The maximum length is 512 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
