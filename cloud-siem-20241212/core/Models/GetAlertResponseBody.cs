// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>If this value is true, the minor engine version is not the latest version.</para>
        /// <remarks>
        /// <para>If the minor engine version of your server is not the latest version, the sampling logs may be inaccurate, which causes inaccurate IP statistics. We recommend that you upgrade the minor engine version at your earliest convenience.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Alert")]
        [Validation(Required=false)]
        public GetAlertResponseBodyAlert Alert { get; set; }
        public class GetAlertResponseBodyAlert : TeaModel {
            /// <summary>
            /// <para>The alert content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{***}</para>
            /// </summary>
            [NameInMap("AlertRecord")]
            [Validation(Required=false)]
            public string AlertRecord { get; set; }

            /// <summary>
            /// <para>The alert UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_1175554881779200_e59368b3ce1690eae7978f7712a69050</para>
            /// </summary>
            [NameInMap("AlertUuid")]
            [Validation(Required=false)]
            public string AlertUuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
