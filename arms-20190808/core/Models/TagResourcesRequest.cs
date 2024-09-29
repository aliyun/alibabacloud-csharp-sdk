// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resource IDs. You can specify a maximum of 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the ARMS resources for which you want to modify tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WEB: Browser Monitoring</description></item>
        /// <item><description>APPLICATION: Application Monitoring</description></item>
        /// <item><description>PROMETHEUS: Managed Service for Prometheus</description></item>
        /// <item><description>SYNTHETICTASK: Synthetic Monitoring</description></item>
        /// <item><description>ALERTRULE: Application Monitoring alert rule</description></item>
        /// <item><description>PROMETHEUSALERTRULE: Managed Service for Prometheus alert rule</description></item>
        /// <item><description>XTRACEAPP: Managed Service for OpenTelemetry</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource. You can specify a maximum of 20 tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
