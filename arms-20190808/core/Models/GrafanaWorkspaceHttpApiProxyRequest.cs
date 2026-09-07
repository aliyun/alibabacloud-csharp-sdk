// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceHttpApiProxyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>example1:
        /// {&quot;method&quot;:&quot;GET&quot;,&quot;path&quot;:&quot;/api/dashboards/tags&quot;}
        /// example2:
        /// {
        ///   &quot;method&quot;: &quot;POST&quot;,
        ///   &quot;path&quot;: &quot;/api/dashboards/db&quot;,
        ///   &quot;headers&quot;: { &quot;Content-Type&quot;: &quot;application/json&quot; },
        ///   &quot;body&quot;: &quot;{\&quot;dashboard\&quot;:{\&quot;id\&quot;:null,\&quot;uid\&quot;:null,\&quot;title\&quot;:\&quot;demo\&quot;,\&quot;schemaVersion\&quot;:16},\&quot;overwrite\&quot;:false}&quot;
        /// }
        /// example3:
        /// {&quot;method&quot;:&quot;GET&quot;,&quot;path&quot;:&quot;/api/datasources&quot;,&quot;queryParams&quot;:{&quot;type&quot;:[&quot;prometheus&quot;,&quot;mysql&quot;]}}</para>
        /// </summary>
        [NameInMap("BodyStr")]
        [Validation(Required=false)]
        public string BodyStr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-cn-06f4xyxjo01</para>
        /// </summary>
        [NameInMap("GrafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
