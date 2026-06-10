// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppPluginsRequest : TeaModel {
        /// <summary>
        /// <para>Business ID of the application instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250820143531000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Valid range: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token indicating the start of the next query. Empty if there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Status of the dataset acceleration instance. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>Created: Initialization.  </description></item>
        /// <item><description>Running: Running.  </description></item>
        /// <item><description>Stopped: Stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_whitelist</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>Platform</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux/amd64</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
