// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateIntegrationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically clear alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRecover")]
        [Validation(Required=false)]
        public bool? AutoRecover { get; set; }

        /// <summary>
        /// <para>The description of the alert integration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The fields whose values are deduplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LABEL.dimensions::LABEL.ruleId</para>
        /// </summary>
        [NameInMap("DuplicateKey")]
        [Validation(Required=false)]
        public string DuplicateKey { get; set; }

        /// <summary>
        /// <para>The extended mapped fields are mapped to the fields of ARMS alerts. For more information, see the description of the ExtendedFieldRedefineRules parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;redefineType&quot;:&quot;EXTRACT&quot;,
        ///         &quot;matchExpression&quot;:null,
        ///         &quot;fieldName&quot;:&quot;dimensions&quot;,
        ///         &quot;expression&quot;:null,
        ///         &quot;mappingRuleList&quot;:[</para>
        /// <pre><c>    ],
        ///     &quot;name&quot;:&quot;dimensions&quot;,
        ///     &quot;integrationId&quot;:1234,
        ///     &quot;jsonPath&quot;:&quot;$.dimensions&quot;,
        ///     &quot;id&quot;:10013,
        ///     &quot;fieldType&quot;:&quot;LABEL&quot;
        /// },
        /// {
        ///     &quot;redefineType&quot;:&quot;EXTRACT&quot;,
        ///     &quot;matchExpression&quot;:null,
        ///     &quot;fieldName&quot;:&quot;expression&quot;,
        ///     &quot;expression&quot;:null,
        ///     &quot;mappingRuleList&quot;:[
        /// 
        ///     ],
        ///     &quot;name&quot;:&quot;expression&quot;,
        ///     &quot;integrationId&quot;:1234,
        ///     &quot;jsonPath&quot;:&quot;$.expression&quot;,
        ///     &quot;id&quot;:10014,
        ///     &quot;fieldType&quot;:&quot;LABEL&quot;
        /// }
        /// </c></pre>
        /// <para>]</para>
        /// </summary>
        [NameInMap("ExtendedFieldRedefineRules")]
        [Validation(Required=false)]
        public string ExtendedFieldRedefineRules { get; set; }

        /// <summary>
        /// <para>The predefined mapped fields are mapped to the fields of ARMS alerts. The predefined mapped fields were generated when the alert integration was created. For more information, see the description of the FieldRedefineRules parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;redefineType&quot;:&quot;EXTRACT&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;alertname&quot;, &quot;expression&quot;:null, &quot;mappingRuleList&quot;:[ ], &quot;name&quot;:&quot;Alert name&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:&quot;$.alertName&quot;, &quot;id&quot;:10001, &quot;fieldType&quot;:&quot;LABEL&quot; }, { &quot;redefineType&quot;:&quot;MAP&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;severity&quot;, &quot;expression&quot;:null, &quot;mappingRuleList&quot;:[ { &quot;mappingValue&quot;:&quot;critical&quot;, &quot;mappingName&quot;:&quot;P1&quot;, &quot;mappingType&quot;:&quot;MAP&quot;, &quot;originValue&quot;:&quot;CRITICAL&quot; }, { &quot;mappingValue&quot;:&quot;error&quot;, &quot;mappingName&quot;:&quot;P2&quot;, &quot;mappingType&quot;:&quot;MAP&quot;, &quot;originValue&quot;:&quot;WARN&quot; }, { &quot;mappingValue&quot;:&quot;warning&quot;, &quot;mappingName&quot;:&quot;P3&quot;, &quot;mappingType&quot;:&quot;MAP&quot;, &quot;originValue&quot;:&quot;INFO&quot; } ], &quot;name&quot;:&quot;Alert level&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:&quot;$.triggerLevel&quot;, &quot;id&quot;:10002, &quot;fieldType&quot;:&quot;LABEL&quot; }, { &quot;redefineType&quot;:&quot;EXTRACT&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;message&quot;, &quot;expression&quot;:&quot;{{$labels.namespace}} / {{$labels.dimensions}} Alert content {{ $labels.alertname }}, Current value {{$value}}.&quot;, &quot;mappingRuleList&quot;:[ ], &quot;name&quot;:&quot;Alert description&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:null, &quot;id&quot;:10003, &quot;fieldType&quot;:&quot;ANNOTATION&quot; }, { &quot;redefineType&quot;:&quot;EXTRACT&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;value&quot;, &quot;expression&quot;:null, &quot;mappingRuleList&quot;:[ ], &quot;name&quot;:&quot;Alert sample value&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:&quot;$.curValue&quot;, &quot;id&quot;:10004, &quot;fieldType&quot;:&quot;ANNOTATION&quot; }, { &quot;redefineType&quot;:&quot;EXTRACT&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;source&quot;, &quot;expression&quot;:null, &quot;mappingRuleList&quot;:[ ], &quot;name&quot;:&quot;Source&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:null, &quot;id&quot;:10007, &quot;fieldType&quot;:&quot;LABEL&quot; }, { &quot;redefineType&quot;:&quot;ADD&quot;, &quot;matchExpression&quot;:null, &quot;fieldName&quot;:&quot;generatorUrl&quot;, &quot;expression&quot;:&quot;<a href="https://cloudmonitor.console.aliyun.com/index.htm#/alarmInfo/name=%7B%7B$labels.ruleId%7D%7D%5C%5C&searchValue=%5C%5C&searchType=name%5C%5C&searchProduct=/history/all/searchKey:%7B%7B$labels.ruleId%7D%7D,startTime:%7B%7Bsub">https://cloudmonitor.console.aliyun.com/index.htm#/alarmInfo/name={{$labels.ruleId}}\\&amp;searchValue=\\&amp;searchType=name\\&amp;searchProduct=/history/all/searchKey:{{$labels.ruleId}},startTime:{{sub</a> $startsAt 300000}},endTime:{{$endsAt}}&quot;, &quot;mappingRuleList&quot;:[ ], &quot;name&quot;:&quot;Event URL&quot;, &quot;integrationId&quot;:1234, &quot;jsonPath&quot;:&quot;<a href="https://cloudmonitor.console.aliyun.com/index.htm#/alarmInfo/name=%7B%7B$labels.ruleId%7D%7D%5C%5C&searchValue=%5C%5C&searchType=name%5C%5C&searchProduct=/history/all/searchKey:%7B%7B$labels.ruleId%7D%7D,startTime:%7B%7Bsub">https://cloudmonitor.console.aliyun.com/index.htm#/alarmInfo/name={{$labels.ruleId}}\\&amp;searchValue=\\&amp;searchType=name\\&amp;searchProduct=/history/all/searchKey:{{$labels.ruleId}},startTime:{{sub</a> $startsAt 300000}},endTime:{{$endsAt}}&quot;, &quot;id&quot;:10012, &quot;fieldType&quot;:&quot;GENERATE_URL&quot; } ]</para>
        /// </summary>
        [NameInMap("FieldRedefineRules")]
        [Validation(Required=false)]
        public string FieldRedefineRules { get; set; }

        /// <summary>
        /// <para>The field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.</para>
        /// <remarks>
        /// <para>Only the Log Service alert integration supports the parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>$.status</para>
        /// </summary>
        [NameInMap("InitiativeRecoverField")]
        [Validation(Required=false)]
        public string InitiativeRecoverField { get; set; }

        /// <summary>
        /// <para>The value of the field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.</para>
        /// <remarks>
        /// <para>Only the Log Service alert integration supports the parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("InitiativeRecoverValue")]
        [Validation(Required=false)]
        public string InitiativeRecoverValue { get; set; }

        /// <summary>
        /// <para>The ID of the alert integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("IntegrationId")]
        [Validation(Required=false)]
        public long? IntegrationId { get; set; }

        /// <summary>
        /// <para>The name of the alert integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudMonitor integration</para>
        /// </summary>
        [NameInMap("IntegrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// <para>The service of the alert integration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLOUD_MONITOR: CloudMonitor</description></item>
        /// <item><description>LOG_SERVICE: Log Service</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_MONITOR</para>
        /// </summary>
        [NameInMap("IntegrationProductType")]
        [Validation(Required=false)]
        public string IntegrationProductType { get; set; }

        /// <summary>
        /// <para>The activity of the alert integration</para>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The period of time within which alert events are automatically cleared. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("RecoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// <para>The total number of alert events and the number of abnormal alert events in the last hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[0,0]</para>
        /// </summary>
        [NameInMap("Stat")]
        [Validation(Required=false)]
        public string Stat { get; set; }

        /// <summary>
        /// <para>Indicates whether the alert integration was enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public bool? State { get; set; }

    }

}
