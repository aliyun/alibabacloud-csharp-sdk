// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaInfoJobRequest : TeaModel {
        /// <summary>
        /// <para>The input for the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobRequestInput Input { get; set; }
        public class SubmitMediaInfoJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The source of the input media:</para>
            /// <list type="bullet">
            /// <item><description>If <c>Type</c> is <c>OSS</c>, set this parameter to the URL of the input file. You can use OSS (<c>oss://</c>), HTTP, or HTTPS URLs.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must first add the OSS bucket specified in the URL to Intelligent Media Management Service (IMS) by using <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a>.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If <c>Type</c> is <c>Media</c>, set this parameter to the media asset ID.</description></item>
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
            /// <para>The type of the input media.</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: The input is an OSS file.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: The input is a media asset ID.</para>
            /// </description></item>
            /// </list>
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
        /// <para>The scheduling settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaInfoJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The job priority. A higher value means a higher priority. Valid values range from 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The custom user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
