// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ExportImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run to check the request\&quot;s validity without actually exporting the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Performs a dry run. If the check succeeds, the <c>DryRunOperation</c> error code is returned. If the check fails, an error is returned.</description></item>
        /// <item><description><c>false</c>: Sends a normal request. If the check succeeds, the image is exported.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The format of the exported image file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>raw.</para>
        /// </description></item>
        /// <item><description><para>vhd.</para>
        /// </description></item>
        /// <item><description><para>qcow2.</para>
        /// </description></item>
        /// <item><description><para>vmdk.</para>
        /// </description></item>
        /// <item><description><para>vdi.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: raw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>raw</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// <para>The ID of the custom image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The destination OSS bucket for the exported image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testexportImage</para>
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// <para>The prefix for the OSS object. The prefix must be 1 to 30 characters in length and can consist of letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EcsExport</para>
        /// </summary>
        [NameInMap("OSSPrefix")]
        [Validation(Required=false)]
        public string OSSPrefix { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the custom image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role used to export the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSImageExportDefaultRole</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
