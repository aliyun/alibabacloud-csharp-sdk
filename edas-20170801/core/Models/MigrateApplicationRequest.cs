// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class MigrateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs.</para>
        /// </summary>
        [NameInMap("appIds")]
        [Validation(Required=false)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// <para>The operation command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>export: Export.</description></item>
        /// <item><description>import: Import.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>export</para>
        /// </summary>
        [NameInMap("cmd")]
        [Validation(Required=false)]
        public string Cmd { get; set; }

        /// <summary>
        /// <para>Specifies whether to export the application binary. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{withBinary:true}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The raw data for the application to be imported, which is sourced from the JSON file of the exported application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;job_id&quot;:&quot;b72c0ed4-a69f-4872-b4c6-def5555bfd3e&quot;,&quot;app_info&quot;:&quot;xxxx&quot;</para>
        /// </summary>
        [NameInMap("rawData")]
        [Validation(Required=false)]
        public string RawData { get; set; }

        /// <summary>
        /// <para>regionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
