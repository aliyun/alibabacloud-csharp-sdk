// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        /// <summary>
        /// <para>The video barrages (on-screen comments).</para>
        /// <remarks>
        /// <para>If specified, it overrides the barrages specified in the Media object.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hello world</para>
        /// </summary>
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) files for the cover images, specified as a JSON array. You can specify up to five cover images.</para>
        /// <remarks>
        /// <para>If specified, this parameter overrides the cover image information in the <b>Media</b> object.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.jpeg&quot;,&quot;RoleArn&quot;:&quot;acs:ram::1997018457688683:role/AliyunICEDefaultRole&quot;}]</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        /// <summary>
        /// <para>The video description. The maximum length is 128 bytes.</para>
        /// <remarks>
        /// <para>If specified, this parameter overrides the description specified in the Media object.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input file to censor.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestInput Input { get; set; }
        public class SubmitMediaCensorJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The identifier for the input file. You can specify either an OSS URL or a media ID.
            /// Valid OSS URL formats:</para>
            /// <para>1\. <c>oss://bucket/object</c></para>
            /// <para>2\. <c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c></para>
            /// <para>The <c>bucket</c> must be in the same region as the project, and <c>object</c> is the path to the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1b1b9cd148034739af413150fded****</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <para><c>OSS</c>: an OSS URL</para>
            /// <para><c>Media</c>: a media ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The callback path. Both Message Service (MNS) and HTTP callbacks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mns://125340688170****.oss-cn-shanghai.aliyuncs.com/queues/example-pipeline</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The output location for screenshots. The censor job generates screenshots and a result JSON file in the OSS location specified by this parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>Example format: <c>oss://bucket/snapshot-{Count}.jpg</c>, where <c>bucket</c> is the name of an OSS bucket in the same region as the project, and <c>{Count}</c> is a placeholder for the screenshot sequence number.</para>
        /// </description></item>
        /// <item><description><para>The detailed censor results are saved to a file named <c>{jobId}.output</c> in the same OSS folder as the value of <c>Output</c>. For information about the fields in the output file, see <a href="https://help.aliyun.com/document_detail/609211.html">Media censor result file fields</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://sashimi-cn-shanghai/censor/snapshot-{Count}.jpg</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaCensorJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5246b8d12a62433ab77845074039****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The task priority. A higher value indicates a higher priority. Valid values range from 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The template ID. If this parameter is left empty, the service uses the default template for the censor job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00000001-100060</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The video title. The maximum length is 64 bytes.</para>
        /// <remarks>
        /// <para>If specified, this parameter overrides the title specified in the Media object.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Hello World</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data. The maximum length is 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserDatatestid-001-****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
