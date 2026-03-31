// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the compliance results of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): does not query the compliance results of the resource.</description></item>
        /// <item><description>1: queries the compliance results of the resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ComplianceOption")]
        [Validation(Required=false)]
        public int? ComplianceOption { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the resource resides.</para>
        /// <para>For more information about how to query the region ID of a resource, see <a href="https://help.aliyun.com/document_detail/411702.html">ListDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>For more information about how to obtain the ID of a resource, see <a href="https://help.aliyun.com/document_detail/411702.html">ListDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new-bucket</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>For more information about how to obtain the type of a resource, see <a href="https://help.aliyun.com/document_detail/411702.html">ListDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::OSS::Bucket</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
