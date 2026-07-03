// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>列表当前页号， 大于等于 1。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ip</c>: IP address</para>
        /// </description></item>
        /// <item><description><para><c>process</c>: process</para>
        /// </description></item>
        /// <item><description><para><c>file</c>: file</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>实体 uuid。</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// <para>The incident UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>列表每页条数， 最大不超过 100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>威胁分析的数据管理中心所在地。您需要根据资产所在地域，选择管理中心所在地。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou：资产属于中国内地与中国香港</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1：资产属于海外地域</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>管理员切换成其他成员视角的用户 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>视图类型。</para>
        /// <list type="bullet">
        /// <item><description><para>0：当前阿里云账号视图。</para>
        /// </description></item>
        /// <item><description><para>1：企业下所有账号的视图。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
