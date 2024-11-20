// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaCensorJobRequest : TeaModel {
        /// <summary>
        /// <para>The live comments of the video.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the system checks the live comments specified by this parameter instead of the live comments of the input file specified by Media.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hello world</para>
        /// </summary>
        [NameInMap("Barrages")]
        [Validation(Required=false)]
        public string Barrages { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) objects that are used as the thumbnails. Specify the thumbnails in a JSON array. A maximum of five thumbnails are supported.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the system checks the thumbnails specified by this parameter instead of the thumbnails of the input file specified by <b>Media</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.jpeg&quot;,&quot;RoleArn&quot;:&quot;acs:ram::1997018457688683:role/AliyunICEDefaultRole&quot;}]</para>
        /// </summary>
        [NameInMap("CoverImages")]
        [Validation(Required=false)]
        public string CoverImages { get; set; }

        /// <summary>
        /// <para>The video description, which can be up to 128 bytes in length.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the system checks the description specified by this parameter instead of the description of the input file specified by Media.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the file to be moderated.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestInput Input { get; set; }
        public class SubmitMediaCensorJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file. The file can be an OSS object or a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <para>1\. oss://bucket/object</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/object</para>
            /// <para>In the preceding paths, bucket indicates an OSS bucket that resides in the same region as the current project, and object indicates the path of the object in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1b1b9cd148034739af413150fded****</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <para>OSS: OSS object.</para>
            /// <para>Media: media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The callback URL. Simple Message Queue (SMQ, formerly MNS) and HTTP callbacks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mns://125340688170****.oss-cn-shanghai.aliyuncs.com/queues/example-pipeline</para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The output snapshots. The moderation job generates output snapshots and the result JSON file in the path corresponding to the input file.</para>
        /// <list type="bullet">
        /// <item><description>File name format of output snapshots: oss://bucket/snapshot-{Count}.jpg. In the path, bucket indicates an OSS bucket that resides in the same region as the current project, and {Count} is the sequence number of the snapshot.</description></item>
        /// <item><description>The detailed moderation results are stored in the {jobId}.output file in the same OSS folder as the output snapshots. For more information about the parameters in the output file, see <a href="https://help.aliyun.com/document_detail/609211.html">Output parameters of media moderation jobs</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://sashimi-cn-shanghai/censor/snapshot-{Count}.jpg</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The scheduling configurations.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitMediaCensorJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitMediaCensorJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the job is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5246b8d12a62433ab77845074039****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The job priority. A larger value indicates a higher priority. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The template ID. If this parameter is not specified, the default template is used for moderation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00000001-100060</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The video title, which can be up to 64 bytes in length.</para>
        /// <remarks>
        /// <para> If this parameter is specified, the system checks the title specified by this parameter instead of the title of the input file specified by Media.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Hello World</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data, which can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserDatatestid-001-****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
