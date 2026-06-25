// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEventRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range, in UTC. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02 15:04:05</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: a normal event.</para>
        /// </description></item>
        /// <item><description><para>Warning: a warning event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The name of the service instance. To obtain this name, see <a href="https://help.aliyun.com/document_detail/412108.html">ListServiceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo-test-784xxxx85d-hhnd8</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The number of events to return per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query range, in UTC. The default value is 7 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02 15:04:05</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
