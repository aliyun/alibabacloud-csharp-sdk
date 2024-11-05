// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>An array that consists of the IDs of the bastion hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1ghxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the bastion host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PENDING</b>: The bastion host is not initialized.</description></item>
        /// <item><description><b>CREATING</b>: The bastion host is being created.</description></item>
        /// <item><description><b>RUNNING</b>: The bastion host is running.</description></item>
        /// <item><description><b>EXPIRED</b>: The bastion host expired.</description></item>
        /// <item><description><b>CREATE_FAILED</b>: The bastion host fails to be created.</description></item>
        /// <item><description><b>UPGRADING</b>: The configurations of the bastion host are being changed.</description></item>
        /// <item><description><b>UPGRADE_FAILED</b>: The configurations of the bastion host fail to be changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the bastion host belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm26ougi****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>An array consisting of the tags that are added to the bastion hosts.</para>
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
