// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cl-000**************hg9</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;dataServerAddresses&quot;: [
        ///         {
        ///             &quot;host&quot;: &quot;123.123.123.123&quot;,
        ///             &quot;port&quot;: &quot;8080&quot;
        ///         }
        ///     ],
        ///     &quot;sharePath&quot;: &quot;/share&quot;,
        ///     &quot;mountOptions&quot;: &quot;vers=3&quot;,
        ///     &quot;fileSystemType&quot;: &quot;nfs&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ConnectionInfo")]
        [Validation(Required=false)]
        public string ConnectionInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;mountUsername&quot;:&quot;<em><b>&quot;,&quot;mountPassword&quot;:&quot;</b></em>&quot;}</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-0006xo****dtle</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyLocalNas</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/log/&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/&quot;, &quot;/home/bob/&quot;]</para>
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
        /// <para>{}</para>
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
        /// <para>0:24:102400</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

    }

}
