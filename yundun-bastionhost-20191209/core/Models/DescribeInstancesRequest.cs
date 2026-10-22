// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bastionhost instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1ghxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the Bastionhost instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PENDING</b>: Uninitialized</para>
        /// </description></item>
        /// <item><description><para><b>CREATING</b>: Creating </para>
        /// </description></item>
        /// <item><description><para><b>RUNNING</b>: Running </para>
        /// </description></item>
        /// <item><description><para><b>EXPIRED</b>: Expired </para>
        /// </description></item>
        /// <item><description><para><b>CREATE_FAILED</b>: Creation failed</para>
        /// </description></item>
        /// <item><description><para><b>UPGRADING</b>: Upgrading</para>
        /// </description></item>
        /// <item><description><para><b>UPGRADE_FAILED</b>: Upgrade failed</para>
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
        /// <para>Specifies the page number of the returned results. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Settings for a paged query. Specifies the number of Bastionhost instances to display on each page during paging. Default value: <b>10</b>, which indicates that 10 Bastionhost instances are displayed on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Bastionhost instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm26ougi****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the Bastionhost instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance.</para>
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
