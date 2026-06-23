// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the bastion host instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1ghxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the bastion host instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PENDING</b>: The instance is not initialized.</para>
        /// </description></item>
        /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>RUNNING</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>EXPIRED</b>: The instance is expired.</para>
        /// </description></item>
        /// <item><description><para><b>CREATE_FAILED</b>: The instance creation failed.</para>
        /// </description></item>
        /// <item><description><para><b>UPGRADING</b>: The instance is being upgraded.</para>
        /// </description></item>
        /// <item><description><para><b>UPGRADE_FAILED</b>: The instance upgrade failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The page number to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of bastion host instances to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the bastion host instances reside.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the bastion host instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm26ougi****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags attached to the bastion host instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testapi</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
