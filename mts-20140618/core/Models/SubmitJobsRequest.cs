// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitJobsRequest : TeaModel {
        /// <summary>
        /// The information about the input file. For more information, see the "Input" section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
        /// 
        /// > 
        /// 
        /// *   The path of an Object Storage Service (OSS) object must be URL-encoded in UTF-8 before you use the path in MPS.
        /// 
        /// *   The OSS bucket must reside in the same region as your MPS service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// The name of the OSS bucket that stores the output file.
        /// 
        /// *   For more information about the term bucket, see [Terms](https://help.aliyun.com/document_detail/31827.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutputBucket")]
        [Validation(Required=false)]
        public string OutputBucket { get; set; }

        /// <summary>
        /// The region in which the OSS bucket that stores the output file resides.
        /// 
        /// *   The OSS bucket must reside in the same region as MPS.
        /// *   For more information about the term bucket, see [Terms](https://help.aliyun.com/document_detail/31827.html).
        /// </summary>
        [NameInMap("OutputLocation")]
        [Validation(Required=false)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// The job output configurations. For more information, see the "Output" section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
        /// 
        /// *   Specify the value in a JSON array of Output objects. You can specify up to 30 Output objects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the MPS queue. For more information, see [Terms](https://help.aliyun.com/document_detail/31827.html).
        /// 
        /// *   To obtain the ID of an MPS queue, you can log on to the [MPS console](https://mps.console.aliyun.com/overview) and choose **Global Settings** > **MPS Queue and Callback** in the left-side navigation pane.
        /// *   If you want to receive asynchronous message notifications, associate an MNS queue or topic with the MPS queue. For more information, see [Receive notifications](https://www.alibabacloud.com/help/zh/apsaravideo-for-media-processing/latest/receive-message-notifications).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
