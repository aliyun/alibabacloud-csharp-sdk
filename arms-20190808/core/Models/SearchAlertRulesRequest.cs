// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The id of AlertRule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("AlertRuleId")]
        [Validation(Required=false)]
        public string AlertRuleId { get; set; }

        /// <summary>
        /// <para>The type of the application that is associated with the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>TRACE</c>: application</description></item>
        /// <item><description><c>RETCODE</c>: browser</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Default value: <c>10</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process identifier (PID) of the application that is associated with the alert rule. For more information about how to obtain the PID, see <a href="https://help.aliyun.com/document_detail/186100.html?spm=a2c4g.11186623.6.792.1b50654cqcDPyk#title-imy-7gj-qhr">Obtain the PID of an application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atc889zkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID of the alert data. For more information about the mappings between <b>RegionId</b> and <b>SystemRegionId</b>, see the detailed description below the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can obtain the resource group ID in the <b>Resource Management</b> console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the alert rule. For more information about the mappings between <b>RegionId</b> and <b>SystemRegionId</b>, see the detailed description below the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SystemRegionId")]
        [Validation(Required=false)]
        public string SystemRegionId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<SearchAlertRulesRequestTags> Tags { get; set; }
        public class SearchAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The following system preset fields are provided:</para>
            /// <list type="bullet">
            /// <item><description>traceId: the ID of the trace.</description></item>
            /// <item><description>serverApp: the name of the server application.</description></item>
            /// <item><description>clientApp: the name of the client application.</description></item>
            /// <item><description>service: the name of the operation.</description></item>
            /// <item><description>rpc: the type of the call.</description></item>
            /// <item><description>msOfSpan: the duration exceeds a specific value.</description></item>
            /// <item><description>clientIp: the IP address of the client.</description></item>
            /// <item><description>serverIp: the IP address of the server.</description></item>
            /// <item><description>isError: specifies whether the call is abnormal.</description></item>
            /// <item><description>hasTprof: contains only thread profiling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The alert rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlertRuleTitle</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The alert rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: custom alert rules that are used to monitor drill-down data sets</description></item>
        /// <item><description><c>3</c>: custom alert rules that are used to monitor tiled data sets</description></item>
        /// <item><description><c>4</c>: alert rules that are used to monitor the browser, including the default frontend alert rules</description></item>
        /// <item><description><c>5</c>: alert rules that are used to monitor applications, including the default application alert rules</description></item>
        /// <item><description><c>6</c>: the default browser alert rules</description></item>
        /// <item><description><c>7</c>: the default application alert rules</description></item>
        /// <item><description><c>8</c>: Tracing Analysis alert rules</description></item>
        /// <item><description><c>101</c>: Prometheus alert rules</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
