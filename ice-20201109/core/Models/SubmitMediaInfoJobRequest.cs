// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaInfoJobRequest : TeaModel {
        /// <summary>
        /// <para>The input of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobRequestInput Input { get; set; }
        public class SubmitMediaInfoJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The media object.</para>
            /// <list type="bullet">
            /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a> page of the Intelligent Media Services (IMS) console.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/video.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the media object. Valid values: OSS and Media. A value of OSS indicates an Object Storage Service (OSS) object. A value of Media indicates a media asset.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scheduling parameters.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaInfoJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue that is used to run the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid values: 1 to 10. The greater the value, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
