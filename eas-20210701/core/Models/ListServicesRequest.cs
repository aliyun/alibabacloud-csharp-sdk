// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>The field that is used for fuzzy matches. The system performs fuzzy matches only by service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The private gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-1uhcqmsc7x22******</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The name of the service group. For more information about how to query the name of a service group, see <a href="https://help.aliyun.com/document_detail/412109.html">ListServices</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The tag that is used to filter services.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public Dictionary<string, string> Label { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc (default): The query results are sorted in descending order.</description></item>
        /// <item><description>asc: The query results are sorted in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the primary service that corresponds to the Band member service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-ijafy3c8cxxxx</para>
        /// </summary>
        [NameInMap("ParentServiceUid")]
        [Validation(Required=false)]
        public string ParentServiceUid { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota12345</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The name or ID of the resource group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-hd0qwy8cxxxx</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The server role.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DataLoader</description></item>
        /// <item><description>FrontEnd</description></item>
        /// <item><description>DataSet</description></item>
        /// <item><description>SDProxy</description></item>
        /// <item><description>LLMSscheduler</description></item>
        /// <item><description>ScalableJob</description></item>
        /// <item><description>LLMGateway</description></item>
        /// <item><description>Job</description></item>
        /// <item><description>Queue</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LLMGateway</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo_test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Stopped</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Failed</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Complete</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Cloning</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Stopping</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Updating</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Waiting</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>HotUpdate</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Committing</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Starting</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DeleteFailed</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Running</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Developing</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Scaling</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Deleted</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Pending</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Deleting</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Async</description></item>
        /// <item><description>Standard</description></item>
        /// <item><description>Offline Task</description></item>
        /// <item><description>Proxima</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Async</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Standard</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>OfflineTask</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Proxima</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The user ID (UID) of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-c9iw3yitxxxx</para>
        /// </summary>
        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        /// <summary>
        /// <para>The sort field. By default, the query results are sorted by the timestamp type in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
