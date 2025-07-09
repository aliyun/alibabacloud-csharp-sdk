// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class InsertMediaToSearchLibRequest : TeaModel {
        [NameInMap("ImagesInput")]
        [Validation(Required=false)]
        public string ImagesInput { get; set; }

        /// <summary>
        /// <para>The URL of the video, audio, or image file that you want to import to the search library.</para>
        /// <para>Note: Make sure that you specify a correct file name and the bucket in which the file resides is in the same region where this operation is called. Otherwise, the file cannot be found or the operation may fail.</para>
        /// <para>Specify an Object Storage Service (OSS) URL in the following format: oss://[Bucket name]/[File path]. For example, you can specify oss://[example-bucket-<b><b>]/[object_path-</b></b>].</para>
        /// <para>Specify an HTTP URL in the following format: public endpoint. For example, you can specify <a href="http://example-test-%5C%5C*%5C%5C*%5C%5C*%5C%5C*.mp4">http://example-test-\\*\\*\\*\\*.mp4</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-test-****.mp4">http://example-test-****.mp4</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The ID of the media asset. Each media ID is unique. If you leave this parameter empty, a media ID is automatically generated for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>411bed50018971edb60b0764a0ec6***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>video (default)</description></item>
        /// <item><description>image</description></item>
        /// <item><description>audio</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The message body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("MsgBody")]
        [Validation(Required=false)]
        public string MsgBody { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the search library. Default value: ims-default-search-lib.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
