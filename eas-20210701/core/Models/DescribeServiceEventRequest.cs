// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEventRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. By default, the current point in time is the end of the time range to query.</para>
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
        /// <item><description>Normal</description></item>
        /// <item><description>Warning</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The instance name. For more information about how to obtain the instance name, see <a href="https://help.aliyun.com/document_detail/412108.html">ListServiceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo-test-784xxxx85d-hhnd8</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time must be in UTC. The default value is seven days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02 15:04:05</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
