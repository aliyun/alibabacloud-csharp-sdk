// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImagesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. A client token is generated from your client and must be unique among different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data cloud disk snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-acscasca****</para>
        /// </summary>
        [NameInMap("DataSnapshotId")]
        [Validation(Required=false)]
        public string DataSnapshotId { get; set; }

        /// <summary>
        /// <para>The image IDs of the simple application servers. The value can be a JSON array that consists of up to 100 instance IDs. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;fe9c66133a9d4688872869726b52****&quot;, &quot;794c230fd3e64ea19f83f4d7a0ad****&quot;]</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>The image names of the simple application servers. The value can be a JSON array that consists of up to 100 instance IDs. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test1****&quot;, &quot;test2****&quot;]</para>
        /// </summary>
        [NameInMap("ImageNames")]
        [Validation(Required=false)]
        public string ImageNames { get; set; }

        /// <summary>
        /// <para>The instance ID of the simple application server from which the image was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ace0706b2ac4454d984295a94213****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number of the snapshot list.
        /// Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application servers. You can call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to query the list of supported regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bti7cf7yj2i</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query shared images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>False: The response does not include shared images.</para>
        /// </description></item>
        /// <item><description><para>True: Only shared images are returned.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is not specified, all images are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Share")]
        [Validation(Required=false)]
        public bool? Share { get; set; }

        /// <summary>
        /// <para>The system cloud disk snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp14m09pq8***0g6</para>
        /// </summary>
        [NameInMap("SystemSnapshotId")]
        [Validation(Required=false)]
        public string SystemSnapshotId { get; set; }

        /// <summary>
        /// <para>The tags of the custom images.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListCustomImagesRequestTag> Tag { get; set; }
        public class ListCustomImagesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the custom image. Valid values of the tag key length: 1 to 64. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the custom image. Valid values of the tag value length: 1 to 64. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
