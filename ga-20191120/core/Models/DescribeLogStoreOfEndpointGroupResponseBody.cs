// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeLogStoreOfEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("AccessLogRecordCustomizedHeaderList")]
        [Validation(Required=false)]
        public List<string> AccessLogRecordCustomizedHeaderList { get; set; }

        [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-xxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-xxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777E713-8456-55F1-9A69-9AD9EAE2B3B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga_log</para>
        /// </summary>
        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga_project_name</para>
        /// </summary>
        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        /// <summary>
        /// <para>The region ID of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>Indicates whether the endpoint group is bound to the Simple Log Service project.</para>
        /// <list type="bullet">
        /// <item><description><b>on:</b> The endpoint group is bound to the Simple Log Service project.</description></item>
        /// <item><description><b>off:</b> The endpoint group is not bound to the Simple Log Service project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on - binding
        /// off - unbinding</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
