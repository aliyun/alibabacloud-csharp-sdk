// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListTodoOpsTaskApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the bastion host.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-m413tuhlo03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task name or task remarks to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in a paging query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.<br>The maximum value of the PageSize parameter is 100. The default number of entries per page is 20. If PageSize is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The task scheduling type used to filter results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FixTime</b>: scheduled execution.</description></item>
        /// <item><description><b>CycleInterval</b>: periodic execution.</description></item>
        /// <item><description><b>Manual</b>: manually triggered by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

    }

}
