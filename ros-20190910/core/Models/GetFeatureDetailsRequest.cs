// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The one or more features that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Terraform: the Terraform hosting feature.</para>
        /// </description></item>
        /// <item><description><para>ResourceCleaner: the resource cleaner feature. You can use ALIYUN::ROS::ResourceCleaner to create a resource cleaner.</para>
        /// </description></item>
        /// <item><description><para>TemplateScratch: the scenario feature.</para>
        /// </description></item>
        /// <item><description><para>All: all features that are supported by ROS.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terraform</para>
        /// </summary>
        [NameInMap("Feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
