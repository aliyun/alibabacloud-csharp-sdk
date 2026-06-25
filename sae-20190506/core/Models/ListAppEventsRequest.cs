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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Warning</b>: An event that indicates a potential problem.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: An event that indicates a routine operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Warning</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the namespace is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The object kind. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Deployment</b>: The application.</para>
        /// </description></item>
        /// <item><description><para><b>Pod</b>: The application instance.</para>
        /// </description></item>
        /// <item><description><para><b>Service</b>: The Server Load Balancer (SLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>HorizontalPodAutoscaler</b>: The auto scaling policy.</para>
        /// </description></item>
        /// <item><description><para><b>CloneSet</b>: The application.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pod</para>
        /// </summary>
        [NameInMap("ObjectKind")]
        [Validation(Required=false)]
        public string ObjectKind { get; set; }

        /// <summary>
        /// <para>The name of the object. Prefix matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>errew-b86bf540-b4dc-47d8-a42f-b4997c14bd8f-5595cbddd6-x****</para>
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. The value must be an integer from 0 to 10,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The reason for the event. Prefix matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Started</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
