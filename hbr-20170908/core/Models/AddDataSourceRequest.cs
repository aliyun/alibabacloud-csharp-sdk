// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class AddDataSourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cl-0004i0nlngorvgjpl7ck</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;dataServerAddresses\&quot;:[{\&quot;host\&quot;:\&quot;111\&quot;,\&quot;port\&quot;:\&quot;\&quot;}],\&quot;sharePath\&quot;:\&quot;/share\&quot;,\&quot;mountOptions\&quot;:\&quot;\&quot;,\&quot;fileSystemType\&quot;:\&quot;nfs\&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionInfo")]
        [Validation(Required=false)]
        public string ConnectionInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr_detection_source-nas-20250710101315</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON_NAS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>META</para>
        /// </summary>
        [NameInMap("IndexLevel")]
        [Validation(Required=false)]
        public string IndexLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;includes\&quot;:[],\&quot;excludes\&quot;:[],\&quot;conflictPolicy\&quot;:\&quot;OVERWRITE_EXISTING\&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>I|1729493847|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

    }

}
