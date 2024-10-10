// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppEventsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f7730764-d88f-4b9a-8d8e-cd8efbfe****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Warning</b>: an alert.</description></item>
        /// <item><description><b>Normal</b>: a normal event.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Warning</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Deployment</b>: an application.</description></item>
        /// <item><description><b>Pod</b>: an application instance.</description></item>
        /// <item><description><b>Service</b>: a Server Load Balancer (SLB) instance.</description></item>
        /// <item><description><b>HorizontalPodAutoscaler</b>: an auto scaling policy.</description></item>
        /// <item><description><b>CloneSet</b>: an application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pod</para>
        /// </summary>
        [NameInMap("ObjectKind")]
        [Validation(Required=false)]
        public string ObjectKind { get; set; }

        /// <summary>
        /// <para>The name of the object. Fuzzy search by prefix is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>errew-b86bf540-b4dc-47d8-a42f-b4997c14bd8f-5595cbddd6-x****</para>
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 0 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The cause of the event. Fuzzy search by prefix is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Started</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
