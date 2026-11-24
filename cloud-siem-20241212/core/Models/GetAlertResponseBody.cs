// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the minor version is not the latest version.</para>
        /// <remarks>
        /// <para>If the minor version of your server is not the latest, the sampled logs may be inaccurate, resulting in inaccurate IP address statistics. Therefore, we recommend that you upgrade the minor version of your server as soon as possible.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Alert")]
        [Validation(Required=false)]
        public GetAlertResponseBodyAlert Alert { get; set; }
        public class GetAlertResponseBodyAlert : TeaModel {
            /// <summary>
            /// <para>The content of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{***}</para>
            /// </summary>
            [NameInMap("AlertRecord")]
            [Validation(Required=false)]
            public string AlertRecord { get; set; }

            /// <summary>
            /// <para>The UUID of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_1175554881779200_e59368b3ce1690eae7978f7712a69050</para>
            /// </summary>
            [NameInMap("AlertUuid")]
            [Validation(Required=false)]
            public string AlertUuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
