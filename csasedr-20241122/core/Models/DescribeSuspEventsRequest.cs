// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trojan</para>
        /// </summary>
        [NameInMap("AlarmEventName")]
        [Validation(Required=false)]
        public string AlarmEventName { get; set; }

        /// <summary>
        /// <para>The unique ID of the alert event.</para>
        /// <para>To query the exception event information of a single alert event, you must provide the unique ID of the alert event. You can call the DescribeSuspEvents operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8df914418f4211fb****</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <para>The collection of asset types. Not supported by SASE-EDR.</para>
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the cluster for which you want to query alert events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4af4fdf38a98496a9b63c2be5dae****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container search field. Not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container search field. Not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccf9769c22b844ff9b8d57417683b****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Filters alerts by processing group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>N</c>: Pending.</description></item>
        /// <item><description><c>Y</c>: Processed.</description></item>
        /// <item><description><c>A</c>: All.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, all groups are queried. The Status parameter further filters alerts within the selected group. If the specified status does not match the group, an empty result is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The department to which the user belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Supplier Operations Team</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The internal subtype identifiers of the alerts. Separate multiple subtypes with commas (,). This parameter is used to match event names. The valid values must belong to the alert configurations visible to the current account and are not the alert names displayed to users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SASE non-whitelisted startup interception_PC</para>
        /// </summary>
        [NameInMap("EventNames")]
        [Validation(Required=false)]
        public string EventNames { get; set; }

        /// <summary>
        /// <para>The ID of the group to which the asset affected by the alert event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18768</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qin-ubuntu</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The unique ID of the recorded alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The private IP address of the endpoint device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XXX.XXX</para>
        /// </summary>
        [NameInMap("InnerIp")]
        [Validation(Required=false)]
        public string InnerIp { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The urgency levels of the alert events to query. Separate multiple urgency levels with commas (,). The urgency levels are listed in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b>: Urgent.</description></item>
        /// <item><description><b>suspicious</b>: Suspicious.</description></item>
        /// <item><description><b>remind</b>: Reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The name of the asset affected by the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The collection of alert event processing result codes.</para>
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// <para>The end time of the alert processing time. Specify a datetime string in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeEnd")]
        [Validation(Required=false)]
        public string OperateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the alert processing time. Specify a datetime string in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeStart")]
        [Validation(Required=false)]
        public string OperateTimeStart { get; set; }

        /// <summary>
        /// <para>The number of alert events to return on each page in a paging query. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The internal type identifiers of the alerts. Separate multiple types with commas (,). The valid values are derived from the current alert configurations. You can call the DescribeNsasSuspEventType operation to query the Type field in EventTypes. The Name field is the display name and is not used as a fixed enumeration list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Precision defense</para>
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// <para>The alert name or asset information to query.</para>
        /// <para>Note: Fuzzy match is supported. Asset information includes the asset name, public IP address, and private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The custom sort field. Default value: <b>operateTime</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lastTime</b>: Latest occurrence time.</description></item>
        /// <item><description><b>operateTime</b>: Processing time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field takes effect only when Dealed is set to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>operateTime</para>
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// <para>The custom sort order. Default value: <b>desc</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// <item><description><b>desc</b>: Descending order.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field takes effect only when Dealed is set to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The compatibility source classification parameter. This parameter is not used to specify the alert data source. You do not need to specify this parameter for common alert list queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>virus</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The IP address of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.55.XXX.XXX</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>Further filters alerts by individual alert status within the processing group specified by the Dealed parameter. Status descriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c>: No further status restriction. The alerts are still subject to the Dealed group.</description></item>
        /// <item><description><c>1</c>: Pending.</description></item>
        /// <item><description><c>2</c>: Ignored.</description></item>
        /// <item><description><c>4</c>: Manually processed.</description></item>
        /// <item><description><c>8</c>: Whitelisted (marked as false positive).</description></item>
        /// <item><description><c>32</c>: Processed. For example, automatic defense interception succeeded.</description></item>
        /// <item><description><c>64</c>: Expired.</description></item>
        /// </list>
        /// <para>Unprocessed alerts are automatically marked as expired if more than 31 days have passed since the last occurrence.</para>
        /// <para>Deleted alerts cannot be queried. If the specified status does not belong to the group specified by Dealed, an empty result is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert is in strict mode. Not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public string StrictMode { get; set; }

        /// <summary>
        /// <para>The ATT&amp;CK tactic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0001</para>
        /// </summary>
        [NameInMap("TacticId")]
        [Validation(Required=false)]
        public string TacticId { get; set; }

        /// <summary>
        /// <para>The container search target type. Not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The end time of the latest occurrence. Specify a datetime string in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the latest occurrence. Specify a datetime string in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// <para>The unique key of the security alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73fc06fb175a7405697e402f52864****</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The username of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers for which you want to query alerts. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb5d2484-f10e-450d-8917-3e79667e****,0e7c2fcd-7100-42c7-a21a-db6e4f32****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
