// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateEdgeTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3b-4d18-395c-8106-ff21a6</b></b></b></para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the edge transcoding task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The URL of the input stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://mydomain/app/stream1</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInput { get; set; }

        /// <summary>
        /// <para>The URL of the output stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://testdomain/app/stream2</para>
        /// </summary>
        [NameInMap("StreamOutput")]
        [Validation(Required=false)]
        public string StreamOutput { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
